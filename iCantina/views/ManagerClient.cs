using iCantina.models;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iCantina.views.Employee;

namespace iCantina.views
{
    public partial class ManagerClient : Form
    {
        private Professor selectedTeacher;
        private Estudante selectedStudent;

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Global.caminhoPhoto;
        string destinoCompleto = "";
        private const string DefaultPhotoPath = "../../Assets/icons/Person_Black.png";

        public ManagerClient()
        {
            InitializeComponent();
        }

        // Class
        public class ListBoxItemTeacher
        {
            public Professor professor { get; set; }
            public string DisplayText { get; set; }
            public string PhotoPath { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }
        public class ListBoxItemStudent
        {
            public Estudante estudante { get; set; }
            public string DisplayText { get; set; }
            public string PhotoPath { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        // Funções
        // Função para Salvar novo Cliente
        private void SaveTeacher(Professor professor)
        {
            using (var db = new iCantinaContext())
            {
                db.utilizadors.Add(professor);
                db.SaveChanges();
            }
        }
        private void SaveStudent(Estudante estudante)
        {
            using (var db = new iCantinaContext())
            {
                db.utilizadors.Add(estudante);
                db.SaveChanges();
            }
        }

        // Button Create
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string ConfirmeStudent = textBoxStudent.Text;
            string teacher = textBoxTeacher.Text;
            string confirmeNif = textBoxNif.Text;

            int student;
            bool isStudent = int.TryParse(textBoxStudent.Text, out student);

            int nif;
            bool isNumeric = int.TryParse(textBoxNif.Text, out nif);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(confirmeNif))
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório");
            }
            else if (confirmeNif.Length != 9 || !isNumeric)
            {
                MessageBox.Show("O NIF deve conter exatamente 9 caracteres numéricos.");
            }
            if (checkBoxTeacher.Checked)
            {
                if (string.IsNullOrEmpty(teacher))
                {
                    MessageBox.Show("Campos de preenchimento obrigatório");
                    return;
                }
                try
                {
                    MailAddress adr = new MailAddress(teacher);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Email incorreto: {ex.Message}");
                    return;
                }
                try
                {
                    using (var db = new iCantinaContext())
                    {
                        bool EmailExists = db.utilizadors.OfType<Professor>().Any(u => u.Email == teacher);
                        bool nifExists = db.utilizadors.Any(u => u.Nif == nif);

                        if (nifExists)
                        {
                            MessageBox.Show("O nif já existe. Por favor, coloque o seu nif");
                        }
                        else if (EmailExists)
                        {
                            MessageBox.Show("O Email já existe. Por favor, escolha outro Email");
                        }

                        var novoProfessor = new Professor()
                        {
                            Name = name,
                            Nif = nif,
                            Email = teacher,
                            Photo = string.IsNullOrEmpty(destinoCompleto) ? DefaultPhotoPath : destinoCompleto
                        };

                        SaveTeacher(novoProfessor);

                        listBoxClient.Items.Add(new ListBoxItemTeacher
                        {
                            professor = novoProfessor,
                            DisplayText = $"{novoProfessor.Name} - {novoProfessor.Email} - Nif: {novoProfessor.Nif}",
                            PhotoPath = novoProfessor.Photo
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro na base de dados: {ex.Message}");
                }
            }
            else if (checkBoxStudent.Checked)
            {
                if (string.IsNullOrEmpty(ConfirmeStudent))
                {
                    MessageBox.Show("Campos de preenchimento obrigatório");
                    return;
                }
                try
                {
                    using (var db = new iCantinaContext())
                    {
                        bool NumStudentExists = db.utilizadors.OfType<Estudante>().Any(u => u.NumeroEstudante == student);
                        bool nifExists = db.utilizadors.Any(u => u.Nif == nif);

                        if (nifExists)
                        {
                            MessageBox.Show("O nif já existe. Por favor, coloque o seu nif");
                        }
                        else if (NumStudentExists)
                        {
                            MessageBox.Show("O numero de estudante já existe. Por favor, escolha outro numero de estudante");
                        }

                        var novoEstudante = new Estudante()
                        {
                            Name = name,
                            Nif = nif,
                            NumeroEstudante = student,
                            Photo = string.IsNullOrEmpty(destinoCompleto) ? DefaultPhotoPath : destinoCompleto
                        };

                        SaveStudent(novoEstudante);

                        listBoxClient.Items.Add(new ListBoxItemStudent
                        {
                            estudante = novoEstudante,
                            DisplayText = $"{novoEstudante.Name} - {novoEstudante.NumeroEstudante} - Nif: {novoEstudante.Nif}",
                            PhotoPath = novoEstudante.Photo
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro na base de dados: {ex.Message}");
                }
            }
        }

        private void checkBoxTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTeacher.Checked == true)
            {
                checkBoxStudent.Checked = false;

                labelmultiescolha.Text = "Email";
                labelmultiescolha.Visible = true;
                textBoxStudent.Visible = false;
                textBoxTeacher.Visible = true;
            }
            else if (checkBoxTeacher.Checked == false)
            {
                labelmultiescolha.Visible = false;
                textBoxTeacher.Visible = false;
            }
        }

        private void checkBoxStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStudent.Checked == true)
            {
                checkBoxTeacher.Checked = false;

                labelmultiescolha.Text = "Numero Estudante";
                labelmultiescolha.Visible = true;
                textBoxTeacher.Visible = false;
                textBoxStudent.Visible = true;
            }
            else if (checkBoxStudent.Checked == false)
            {
                labelmultiescolha.Visible = false;
                textBoxStudent.Visible = false;
            }
        }

        // Button Search
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchName = textBoxName.Text;
            string searchNumStudent = textBoxStudent.Text;
            string searchNifText = textBoxNif.Text;

            int student;
            int searchNif;

            bool isStudent = int.TryParse(textBoxStudent.Text, out student);
            bool isNumeric = int.TryParse(searchNifText, out searchNif);

            try
            {
                using (var db = new iCantinaContext())
                {
                    if (checkBoxTeacher.Checked)
                    {
                        var query = db.utilizadors.OfType<Professor>().AsQueryable();

                        if (!string.IsNullOrEmpty(searchName))
                        {
                            query = query.Where(f => f.Name.Contains(searchName));
                        }

                        if (!string.IsNullOrEmpty(textBoxTeacher.Text))
                        {
                            query = query.Where(f => f.Email.Contains(textBoxTeacher.Text));
                        }

                        if (isNumeric)
                        {
                            query = query.Where(f => f.Nif == searchNif);
                        }

                        var result = query.ToList();
                        listBoxClient.Items.Clear();

                        if (result.Any())
                        {
                            foreach (var professor in result)
                            {
                                listBoxClient.Items.Add(new ListBoxItemTeacher
                                {
                                    professor = professor,
                                    DisplayText = $"{professor.Name} - {professor.Email} - NIF: {professor.Nif}",
                                    PhotoPath = string.IsNullOrEmpty(professor.Photo) ? DefaultPhotoPath : professor.Photo
                                });
                            }
                        }
                        else
                        {
                            listBoxClient.Items.Add("Nenhum professor encontrado.");
                        }
                    }
                    else if (checkBoxStudent.Checked)
                    {
                        var query = db.utilizadors.OfType<Estudante>().AsQueryable();

                        if (!string.IsNullOrEmpty(searchName))
                        {
                            query = query.Where(f => f.Name.Contains(searchName));
                        }

                        if (!string.IsNullOrEmpty(searchNumStudent) && isStudent)
                        {
                            query = query.Where(f => f.NumeroEstudante == student);
                        }

                        if (isNumeric)
                        {
                            query = query.Where(f => f.Nif == searchNif);
                        }

                        var result = query.ToList();
                        listBoxClient.Items.Clear();

                        if (result.Any())
                        {
                            foreach (var estudante in result)
                            {
                                listBoxClient.Items.Add(new ListBoxItemStudent
                                {
                                    estudante = estudante,
                                    DisplayText = $"{estudante.Name} - {estudante.NumeroEstudante} - NIF: {estudante.Nif}",
                                    PhotoPath = string.IsNullOrEmpty(estudante.Photo) ? DefaultPhotoPath : estudante.Photo
                                });
                            }
                        }
                        else
                        {
                            listBoxClient.Items.Add("Nenhum estudante encontrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na base de dados: {ex.Message}");
            }
        }

        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpar seleção anterior
            selectedTeacher = null;
            selectedStudent = null;

            // Verifica se um item está selecionado
            if (listBoxClient.SelectedItem != null)
            {
                if (listBoxClient.SelectedItem is ListBoxItemTeacher itemTeacher)
                {
                    // Se for um professor, atualiza os campos com as informações do professor
                    textBoxName.Text = itemTeacher.professor.Name;
                    textBoxNif.Text = itemTeacher.professor.Nif.ToString();
                    textBoxTeacher.Text = itemTeacher.professor.Email;
                    checkBoxTeacher.Checked = true;

                    // Definir o professor selecionado
                    selectedTeacher = itemTeacher.professor;

                    // Exibir a foto do professor
                    string photoPath = !string.IsNullOrEmpty(itemTeacher.PhotoPath) &&
                                       System.IO.File.Exists(itemTeacher.PhotoPath)
                                       ? itemTeacher.PhotoPath : DefaultPhotoPath;
                    pictureBoxPhotoClient.ImageLocation = photoPath;
                }
                else if (listBoxClient.SelectedItem is ListBoxItemStudent itemStudent)
                {
                    // Se for um estudante, atualiza os campos com as informações do estudante
                    textBoxName.Text = itemStudent.estudante.Name;
                    textBoxNif.Text = itemStudent.estudante.Nif.ToString();
                    textBoxStudent.Text = itemStudent.estudante.NumeroEstudante.ToString();
                    checkBoxStudent.Checked = true;

                    // Definir o estudante selecionado
                    selectedStudent = itemStudent.estudante;

                    // Exibir a foto do estudante
                    string photoPath = !string.IsNullOrEmpty(itemStudent.PhotoPath) &&
                                       System.IO.File.Exists(itemStudent.PhotoPath)
                                       ? itemStudent.PhotoPath : DefaultPhotoPath;
                    pictureBoxPhotoClient.ImageLocation = photoPath;
                }
            }
        }

        // Button Edit
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Se um professor estiver selecionado
            if (selectedTeacher != null)
            {
                selectedTeacher.Name = textBoxName.Text;
                selectedTeacher.Email = textBoxTeacher.Text;
                int.TryParse(textBoxNif.Text, out int updatedNif);
                selectedTeacher.Nif = updatedNif;
                selectedTeacher.Photo = string.IsNullOrEmpty(destinoCompleto) ? selectedTeacher.Photo : destinoCompleto;

                // Atualizar na base de dados
                using (var db = new iCantinaContext())
                {
                    db.Entry(selectedTeacher).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            // Se um estudante estiver selecionado
            else if (selectedStudent != null)
            {
                selectedStudent.Name = textBoxName.Text;
                int.TryParse(textBoxStudent.Text, out int updatedStudentNumber);
                selectedStudent.NumeroEstudante = updatedStudentNumber;
                int.TryParse(textBoxNif.Text, out int updatedNif);
                selectedStudent.Nif = updatedNif;
                selectedStudent.Photo = string.IsNullOrEmpty(destinoCompleto) ? selectedStudent.Photo : destinoCompleto;

                // Atualizar na base de dados
                using (var db = new iCantinaContext())
                {
                    db.Entry(selectedStudent).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente da lista para editar.");
                return;
            }

            MessageBox.Show("Dados do cliente atualizados com sucesso.");

            // Atualizar a lista para refletir as mudanças
            listBoxClient.Items.Clear();
            buttonSearch_Click(null, null);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Verificar se um professor está selecionado
            if (selectedTeacher != null)
            {
                try
                {
                    using (var db = new iCantinaContext())
                    {
                        // Marcar o professor para exclusão
                        db.Entry(selectedTeacher).State = EntityState.Deleted;
                        db.SaveChanges();

                        // Remover o item da lista e limpar os campos
                        listBoxClient.Items.Remove(listBoxClient.SelectedItem);
                        ClearFields();
                        MessageBox.Show("Professor removido com sucesso.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover o professor: {ex.Message}");
                }
            }
            // Verificar se um estudante está selecionado
            else if (selectedStudent != null)
            {
                try
                {
                    using (var db = new iCantinaContext())
                    {
                        // Marcar o estudante para exclusão
                        db.Entry(selectedStudent).State = EntityState.Deleted;
                        db.SaveChanges();

                        // Remover o item da lista e limpar os campos
                        listBoxClient.Items.Remove(listBoxClient.SelectedItem);
                        ClearFields();
                        MessageBox.Show("Estudante removido com sucesso.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover o estudante: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente da lista para remover.");
            }
        }

        // Método auxiliar para limpar os campos de entrada
        private void ClearFields()
        {
            textBoxName.Clear();
            textBoxNif.Clear();
            textBoxTeacher.Clear();
            textBoxStudent.Clear();
            checkBoxTeacher.Checked = false;
            checkBoxStudent.Checked = false;
            pictureBoxPhotoClient.ImageLocation = DefaultPhotoPath;

            // Limpar as variáveis selecionadas
            selectedTeacher = null;
            selectedStudent = null;
        }
    }
}
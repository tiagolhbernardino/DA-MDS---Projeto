using iCantina.controller;
using iCantina.models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace iCantina.views
{
    public partial class Employee : Form
    {
        private Funcionario selectedFuncionario;

        public event EventHandler<string> PhotoUpdated;


        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Global.caminhoPhoto;
        string destinoCompleto = "";
        private const string DefaultPhotoPath = "../../Assets/icons/Person_Black.png";


        public Employee()
        {
            InitializeComponent();
        }


        // Class
        public class ListBoxItem
        {
            public Funcionario Funcionario { get; set; }
            public string DisplayText { get; set; }
            public string PhotoPath { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }


        // Funções
        // Função para Salvar novo Funcionario
        private void SaveFuncionario(Funcionario funcionario)
        {
            using (var db = new iCantinaContext())
            {
                db.utilizadors.Add(funcionario);
                db.SaveChanges();
            }
        }
        // Função para limpar os campos de entrada do formulário
        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxUsername.Text = "";
            textBoxNif.Text = "";
            textBoxPassword.Text = "";
        }


        // limpa a caixa de texto ao começar
        // Name
        private void textBoxName_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxName.Text == "" || textBoxName.Text != "")
            {
                textBoxName.Text = "";

                textBoxName.ForeColor = Color.Black;
            }
        }
        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
            {
                textBoxName.ForeColor = Color.Silver;
            }
        }
        // Nif
        private void textBoxNif_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxNif.Text == "" || textBoxNif.Text != "")
            {
                textBoxNif.Text = "";

                textBoxNif.ForeColor = Color.Black;
            }
        }
        private void textBoxNif_Leave(object sender, EventArgs e)
        {
            if (textBoxNif.Text != "")
            {
                textBoxNif.ForeColor = Color.Silver;
            }
        }
        // Password
        private void textBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "" || textBoxPassword.Text != "")
            {
                textBoxPassword.Text = "";

                textBoxPassword.ForeColor = Color.Black;

                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "")
            {
                textBoxPassword.ForeColor = Color.Silver;
            }
        }
        // Username
        private void textBoxUsername_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxUsername.Text != "")
            {
                textBoxUsername.Text = "";

                textBoxUsername.ForeColor = Color.Black;
            }
        }
        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "")
            {
                textBoxUsername.ForeColor = Color.Silver;
            }
        }


        // Cria um novo funcionário
        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            destinoCompleto = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }

            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
            {
                pictureBoxPhoto.ImageLocation = destinoCompleto;

                using (var db = new iCantinaContext())
                {
                    try
                    {
                        var currentUser = db.utilizadors.Find(sessionManager.CurrentUser.Id);
                        if (currentUser != null)
                        {
                            currentUser.Photo = destinoCompleto;
                            db.SaveChanges();

                            // Atualizar o usuário na sessão
                            sessionManager.CurrentUser.Photo = destinoCompleto;

                            PhotoUpdated?.Invoke(this, destinoCompleto);
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Erro na base de dados: {ex.Message}");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Arquivo não copiado");
            }
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string ConfirmeNif = textBoxNif.Text;
            int nif;

            bool isNumeric = int.TryParse(textBoxNif.Text, out nif);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(ConfirmeNif))
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório");
            }
            else if(ConfirmeNif.Length != 9 || !isNumeric)
            {
                MessageBox.Show("O NIF deve conter exatamente 9 caracteres numéricos.");
            }
            else
            {
                try
                {
                    using (var db = new iCantinaContext())
                    {
                        bool usernameExists = db.utilizadors.OfType<Funcionario>().Any(u => u.Username == username);
                        bool nifExists = db.utilizadors.Any(u => u.Nif == nif);

                        if (nifExists)
                        {
                            MessageBox.Show("O nif já existe. Por favor, coloque o seu nif");
                        }
                        else if (usernameExists)
                        {
                            MessageBox.Show("O username já existe. Por favor, escolha outro username");
                        }
                        else
                        {
                            var novoFuncionario = new Funcionario()
                            {
                                Name = name,
                                Nif = nif,
                                Username = username,
                                Password = password,
                                Photo = string.IsNullOrEmpty(destinoCompleto) ? DefaultPhotoPath : destinoCompleto
                            };

                            SaveFuncionario(novoFuncionario);


                            listBoxEmployers.Items.Add(new ListBoxItem
                            {
                                Funcionario = novoFuncionario,
                                DisplayText = $"{novoFuncionario.Name} - {novoFuncionario.Username} - Nif: {novoFuncionario.Nif}",
                                PhotoPath = novoFuncionario.Photo
                            });
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Erro na base de dados: {ex.Message}");
                }
            }
        }

        // Procurar funcionário
        private void ButtonShearch_Click(object sender, EventArgs e)
        {
            string searchName = textBoxName.Text;
            string searchUsername = textBoxUsername.Text;
            string searchNifText = textBoxNif.Text;
            int searchNif;

            bool isNumeric = int.TryParse(searchNifText, out searchNif);

            using (var db = new iCantinaContext())
            {
                // Inicializa a consulta para funcionários
                var query = db.utilizadors.OfType<Funcionario>().AsQueryable();

                // Adiciona filtros com base na entrada do Usuário
                if (!string.IsNullOrEmpty(searchName))
                {
                    query = query.Where(f => f.Name.Contains(searchName));
                }
                else if (!string.IsNullOrEmpty(searchUsername))
                {
                    query = query.Where(f => f.Username.Contains(searchUsername));
                }
                else if(isNumeric)
                {
                    query = query.Where(f => f.Nif == searchNif);
                }

                // Executa a consulta e obtém os resultados
                var result = query.ToList();

                // Limpa a lista anterior de resultados
                listBoxEmployers.Items.Clear();

                // Adiciona os resultados à ListBox
                if (result.Any())
                {
                    foreach (var funcionario in result)
                    {
                        listBoxEmployers.Items.Add(new ListBoxItem 
                        { 
                            Funcionario = funcionario, 
                            DisplayText = $"{funcionario.Name} - {funcionario.Username} - NIF: {funcionario.Nif}",
                            PhotoPath = string.IsNullOrEmpty(funcionario.Photo) ? DefaultPhotoPath : funcionario.Photo,
                        });
                    }
                }
                else
                {
                    listBoxEmployers.Items.Add("Nenhum funcionário encontrado.");
                }
            }
        }

        // Selecionar funcionário
        private void listBoxEmployers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmployers.SelectedItem is ListBoxItem item)
            {
                selectedFuncionario = item.Funcionario;
                textBoxName.Text = selectedFuncionario.Name;
                textBoxUsername.Text = selectedFuncionario.Username;
                textBoxNif.Text = selectedFuncionario.Nif.ToString();
                textBoxPassword.Text = selectedFuncionario.Password;

                // Exibir a foto do funcionário
                string photoPath = !string.IsNullOrEmpty(selectedFuncionario.Photo) 
                                    && File.Exists(selectedFuncionario.Photo) 
                                    ? selectedFuncionario.Photo : DefaultPhotoPath;
                pictureBoxPhoto.ImageLocation = photoPath;
            }
        }

        // Editar os dados do funcionário
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (selectedFuncionario != null)
            {
                selectedFuncionario.Name = textBoxName.Text;
                selectedFuncionario.Username = textBoxUsername.Text;
                selectedFuncionario.Password = textBoxPassword.Text;
                int.TryParse(textBoxNif.Text, out int updatedNif);
                selectedFuncionario.Nif = updatedNif;

                // Atualiza a foto do funcionário
                selectedFuncionario.Photo = string.IsNullOrEmpty(destinoCompleto) ? selectedFuncionario.Photo : destinoCompleto;
                if (!string.IsNullOrEmpty(selectedFuncionario.Photo))
                {
                    selectedFuncionario.Photo = DefaultPhotoPath;
                }

                using (var db = new iCantinaContext())
                {
                    db.Entry(selectedFuncionario).State = EntityState.Modified;
                    db.SaveChanges();
                }

                MessageBox.Show("Dados do funcionário atualizados com sucesso.");
                listBoxEmployers.Items.Clear();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário da lista para editar.");
            }
        }

        // Eliminar o funcionário selecionado
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (selectedFuncionario != null)
            {
                try
                {
                    using (var db = new iCantinaContext())
                    {
                        db.Entry(selectedFuncionario).State = EntityState.Deleted;
                        db.SaveChanges();

                        listBoxEmployers.Items.Remove(listBoxEmployers.SelectedItem);
                        // Método para limpar os campos após a remoção
                        ClearFields();
                        MessageBox.Show("Funcionário removido com sucesso.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover funcionário: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário da lista para remover.");
            }
        }

        
    }
}

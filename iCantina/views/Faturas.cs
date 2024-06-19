using iCantina.controller;
using iCantina.models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace iCantina.views
{
    public partial class Faturas : Form
    {
        public Faturas()
        {
            InitializeComponent();
        }
        private void monthCalendarInvoice_DateSelected(object sender, DateRangeEventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Almoço");
            listBox1.Items.Add("Jantar");
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string selectedMeal = listBox1.SelectedItem.ToString();
            buttonSearch_Click(sender, e);
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxClient.Items.Clear();
            listBoxInvoice.Items.Clear();

            string studentNumber = textBoxStudent.Text;
            string teacherEmail = textBoxTeacher.Text;
            DateTime selectedDate = monthCalendarInvoice.SelectionStart.Date;
            string timePeriod = listBox1.SelectedItem?.ToString();

            try
            {
                using (var db = new iCantinaContext())
                {
                    IQueryable<Fatura> faturasQuery = db.Faturas;

                    if (!string.IsNullOrEmpty(studentNumber))
                    {
                        int numEstudante = int.Parse(studentNumber);
                        faturasQuery = faturasQuery.Where(f => f.Cliente is Estudante &&
                                                         ((Estudante)f.Cliente).NumeroEstudante == numEstudante);
                    }
                    else if (!string.IsNullOrEmpty(teacherEmail))
                    {
                        faturasQuery = faturasQuery.Where(f => f.Cliente is Professor &&
                                                         ((Professor)f.Cliente).Email == teacherEmail);
                    }

                    faturasQuery = faturasQuery.Where(f => f.DataHora.Date == selectedDate);

                    if (timePeriod == "Almoço")
                    {
                        faturasQuery = faturasQuery.Where(f => f.DataHora.TimeOfDay >= TimeSpan.FromHours(6) &&
                                                          f.DataHora.TimeOfDay < TimeSpan.FromHours(18));
                    }
                    else if (timePeriod == "Jantar")
                    {
                        faturasQuery = faturasQuery.Where(f => f.DataHora.TimeOfDay >= TimeSpan.FromHours(18) ||
                                                          f.DataHora.TimeOfDay < TimeSpan.FromHours(6));
                    }

                    var faturas = faturasQuery.ToList();

                    if (faturas.Any())
                    {
                        var firstFatura = faturas.First();
                        labelNameClient.Text = firstFatura.Cliente.Name;

                        foreach (var fatura in faturas)
                        {
                            listBoxClient.Items.Add($"ID: {fatura.Id}, Total: {fatura.Total:C}, Data: {fatura.DataHora}");
                        }
                    }
                    else
                    {
                        labelError.Visible = true;
                        labelError.Text = "Nenhuma fatura encontrada!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar a base de dados: " + ex.Message);
            }
        }

        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*listBoxInvoice.Items.Clear();

            if (listBoxClient.SelectedItem == null) return;

            // Extrair o Id da fatura do item selecionado
            string selectedInvoice = listBoxClient.SelectedItem.ToString();
            // Pegar o Id da fatura
            string invoiceId = selectedInvoice.Split(',')[0].Trim().Split(':')[1].Trim();

            try
            {
                using (var db = new iCantinaContext())
                {
                    // Carregar os itens da fatura selecionada
                    var itemFaturas = db.ItemFaturas
                                        .Where(if => if.FaturaId.ToString() == invoiceId)
                                        .ToList();

                    if (itemFaturas != null)
                    {
                        foreach (var item in itemFaturas)
                        {
                            listBoxInvoice.Items.Add($"{item.Descricao} - {item.Preco:C}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os detalhes da fatura: " + ex.Message);
            }*/
        }

        
    }
}

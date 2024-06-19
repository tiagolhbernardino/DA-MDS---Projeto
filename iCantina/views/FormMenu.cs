using Google.Protobuf.WellKnownTypes;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.views
{
    public partial class FormMenu : Form
    {
        public DateTime dayTime;
        public string type;
        public string typeDishes;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonSeacher_Click(object sender, EventArgs e)
        {
            dayTime = monthCalendarDay.SelectionStart;

            listBoxType.Items.Clear();
            listBoxTime.Items.Clear();

            listBoxTime.Items.Add("Almoço");
            listBoxTime.Items.Add("Jantar");
        }

        private void listBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = listBoxTime.SelectedItem.ToString();

            listBoxType.Items.Clear();

            if(type == "Almoço" || type == "Jantar")
            {
                listBoxType.Items.Add("Carne");
                listBoxType.Items.Add("Peixe");
                listBoxType.Items.Add("Vegetariano");
                listBoxType.Items.Add("Extra");
            }
        }

        private void listBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeDishes = listBoxType.SelectedItem.ToString();

            if(typeDishes == "Carne")
            {
                using (var db = new iCantinaContext())
                {
                    var pratos = db.Pratos.Where(u => u.Tipo == typeDishes && u.Ativo == "Ativo").ToList();

                    if (pratos.Any())
                    {
                        foreach (var prato in pratos)
                        {
                            listBoxMenuType.Items.Add(prato.Descricao);
                        }
                    }
                    else
                    {
                        listBoxMenuType.Items.Add("Nenhum prato encontrado para o tipo selecionado.");
                    }
                }
            }

            
        }
    }
}

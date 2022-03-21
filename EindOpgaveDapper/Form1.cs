using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DapperLibrary;
using DapperLibrary.Models;
using System.Data.SqlClient;
using Dapper;



namespace EindOpgaveDapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpleidingenService opleidingenService = new OpleidingenService();

            var allCampussen = opleidingenService.GetCampussen();
            cmbSelecteerCampus.DataSource = allCampussen;

            var allDocenten=opleidingenService.GetDocenten();
            cmbSelecteerDocent.DataSource = allDocenten;
            
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            OpleidingenService opleidingenService = new OpleidingenService();
            Docent newDocent=new Docent();
            newDocent.CampusNr = cmbSelecteerCampus.SelectedIndex + 1;
            newDocent.Voornaam = txtVoornaam.Text;
            newDocent.Familienaam=txtFamilienaam.Text;
            newDocent.Wedde = Convert.ToInt32(txtWedde.Text);

            if (opleidingenService.AddNewDocent(newDocent))
            {
                MessageBox.Show("Docent toegevoegd aan de Database");
            }
            else
            {
                MessageBox.Show("Er is een probleem.Probeer nog een keer");
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Docent docent = new Docent();
            docent.Voornaam=txtVoornaam.Text;
            docent.Familienaam= txtFamilienaam.Text;
            docent.Wedde = Convert.ToInt32(txtWedde.Text);
            docent.DocentNr = 1;
            docent.CampusNr = 4;

            OpleidingenService opleidingenService = new OpleidingenService();
            opleidingenService.DeleteDocent(1);
        }

        private void cmbSelecteerDocent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSelecteerCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDetailsEenDocent.Items.Clear();

            OpleidingenService opleidingenService = new OpleidingenService();
            int selected = cmbSelecteerCampus.SelectedIndex+1;
            List<Docent> getDetailsDocent = opleidingenService.GetDetailsDocent();
            foreach (var item in getDetailsDocent)
            {
                if (item.CampusNr == selected)
                {
                    lstDetailsEenDocent.Items.Add("Familienaam:"+ item.Familienaam + "Voornaam:"+ item.Voornaam + "Wedde:"+ item.Wedde);
                }
            }
        }
    }
}

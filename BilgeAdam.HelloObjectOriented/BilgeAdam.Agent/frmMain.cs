using BilgeAdam.AgentCommon.Enums;
using BilgeAdam.AgentCommon.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BilgeAdam.Agent
{
    public partial class frmMain : Form
    {
        private List<string> countries;
        public frmMain()//Constructor ***
        {
            InitializeComponent();
            countries = new List<string>
            {
                "Türkiye",
                "Almanya",
                "Rusya",
                "Çekya",
                "Fransa",
                "Japonya",
                "Ukrayna",
                "A.B.D.",
                "Arjantin",
                "Kolombiya",
                "Avustralya",
                "Venezuela"
            };
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rdbFemale.Checked = true;
            rdbSingle.Checked = true;
            cmbCountry.DataSource = countries;

            var newModel = new Model
            {
                firstName = "Natalia",
                lastName = "Vodianova",
                birthDate = new DateTime(1982, 2, 28),
                country = "Rusya",
                gender = Gender.Female,
                heigth = 1.76M,
                weigth = 50,
                size = new Size
                {
                    chest = 83,
                    waist = 62,
                    hips = 86
                },
                status = MaritialStatus.Married
            };
        }
    }
}

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
        private List<Model> models;
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

            models = new List<Model>();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rdbFemale.Checked = true;
            rdbSingle.Checked = true;
            cmbCountry.DataSource = countries;
            var model1 = new Model
            {
                FirstName = "Adriana",
                LastName = "Lima",
                BirthDate = new DateTime(1981, 6, 12),
                Country = "Brezilya",
                Gender = Gender.Female,
                Status = MaritialStatus.Single,
                Heigth = 1.75M,
                Weigth = 53,
                Size = new Size
                {
                    Chest = 90,
                    Waist = 60,
                    Hips = 90
                }
            };
            var model2 = new Model
            {
                FirstName = "Alessandra",
                LastName = "Ambrossio",
                BirthDate = new DateTime(1984, 4, 11),
                Country = "İtalya",
                Gender = Gender.Female,
                Status = MaritialStatus.Married,
                Heigth = 1.82M,
                Weigth = 56,
                Size = new Size
                {
                    Chest = 91,
                    Waist = 61,
                    Hips = 91
                }
            };
            var model3 = new Model
            {
                FirstName = "Anja",
                LastName = "Rubik",
                BirthDate = new DateTime(1983, 8, 9),
                Country = "Polonya",
                Gender = Gender.Female,
                Status = MaritialStatus.Single,
                Heigth = 1.68M,
                Weigth = 49,
                Size = new Size
                {
                    Chest = 87,
                    Waist = 57,
                    Hips = 85
                }
            };
            models.Add(model1);
            models.Add(model2);
            models.Add(model3);

            //models.AddRange(new Model[] { model1, model2, model3 });
            dgvModels.DataSource = models;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newModel = new Model
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = dtpBirthDate.Value,
                Country = cmbCountry.SelectedItem.ToString(),
                Gender = GetGender(),
                Heigth = nudHeight.Value,
                Weigth = nudWeight.Value,
                Size = new Size
                {
                    Chest = nudChest.Value,
                    Waist = nudWaist.Value,
                    Hips = nudHips.Value
                },
                Status = GetStatus()
            };
            models.Add(newModel);
            dgvModels.DataSource = models;
        }

        private Gender GetGender()
        {
            if (rdbFemale.Checked)
            {
                return Gender.Female;
            }
            return Gender.Male;
        }

        private MaritialStatus GetStatus()
        {
            if (rdbSingle.Checked)
            {
                return MaritialStatus.Single;
            }
            return MaritialStatus.Married;
        }
    }
}

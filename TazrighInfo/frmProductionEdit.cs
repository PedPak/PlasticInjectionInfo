using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmProductionEdit : Form
    {
        public long IdEdit;
        Production Prtn = null;

        public frmProductionEdit()
        {
            InitializeComponent();
            IdEdit = 0;
        }

        

        private void chkAllowEdit_CheckedChanged(object sender, EventArgs e)
        {
            ReadOnlyforAll(!chkAllowEdit.Checked);
        }

        private void ReadOnlyforAll(bool Logic)
        {
            txtMaterial.ReadOnly = Logic;
            txtCoiningWeight.ReadOnly = Logic;
            txtHeadTemperature.ReadOnly = Logic;
            txtMidTemperature.ReadOnly = Logic;
            txtBackTemperature.ReadOnly = Logic;
            txtPressure.ReadOnly = Logic;
            txtInjectionTime.ReadOnly = Logic;
            txtWaitTimeAfterInjection.ReadOnly = Logic;
            txtHookWaitTime.ReadOnly = Logic;
            txtEjectorTime.ReadOnly = Logic;
            txtWaitTimeBeforeEjector.ReadOnly = Logic;

            txtEjectorNumber.ReadOnly = Logic;
            txtWaitTimeBetweenEjectors.ReadOnly = Logic;
            txtIntakeTime.ReadOnly = Logic;
            txtHeadCarriageTime.ReadOnly = Logic;
            txtBackCarriageTime.ReadOnly = Logic;

            txtSecondInjectionPressureTime.ReadOnly = Logic;
            txtTotalTimeforCoining.ReadOnly = Logic;

            txtFullAutomaticTime.ReadOnly = Logic;
            txtWorkingTime.ReadOnly = Logic;

        }

        private void frmProductionEdit_Load(object sender, EventArgs e)
        {
            Prtn = new Production();
            Prtn.Id = IdEdit;

            if (!Prtn.GetOne()) { MessageBox.Show(Prtn.ErrorMessage); return; };
                        
            Product Pr = new Product(); Pr.Id = Prtn.ProductCode; if (!Pr.GetOne()) { MessageBox.Show(Pr.ErrorMessage); return; };
            CastFormat Cf = new CastFormat(); Cf.Id = Prtn.CastCode; if (!Cf.GetOne()) { MessageBox.Show(Cf.ErrorMessage); return; };
            Machine Mc = new Machine(); Mc.Id = Prtn.MachineCode; if (!Mc.GetOne()) { MessageBox.Show(Mc.ErrorMessage); return; };

            txtProduct.Text = Pr.Name;
            txtCastFormat.Text = Cf.Name;
            txtMachine.Text = Mc.Name;


            txtMaterial.Text = Prtn.Material;

            txtCoiningWeight.Text=Prtn.CoiningWeight.ToString();
            txtInjectionTime.Text= Prtn.InjectionTime.ToString();
            txtWaitTimeAfterInjection.Text= Prtn.WaitTimeAfterInjection.ToString();
            txtHookWaitTime.Text= Prtn.HookWaitTime.ToString();
            txtEjectorTime.Text= Prtn.EjectorTime.ToString();
            txtHeadTemperature.Text= Prtn.HeadTemperature.ToString();
            txtMidTemperature.Text= Prtn.MidTemperature.ToString();
            txtBackTemperature.Text= Prtn.BackTemperature.ToString();
            txtFullAutomaticTime.Text= Prtn.FullAutomaticTime.ToString();
            txtIntakeTime.Text= Prtn.IntakeTime.ToString();
            txtHeadCarriageTime.Text= Prtn.HeadCarriageTime.ToString();
            txtBackCarriageTime.Text= Prtn.BackCarriageTime.ToString();
            txtWaitTimeBeforeEjector.Text= Prtn.WaitTimeBeforeEjector.ToString();
            txtWaitTimeBetweenEjectors.Text= Prtn.WaitTimeBetweenEjectors.ToString();
            txtEjectorNumber.Text= Prtn.EjectorNumber.ToString();
            txtSecondInjectionPressureTime.Text= Prtn.SecondInjectionPressureTime.ToString();
            txtPressure.Text= Prtn.Pressure.ToString();
            txtWorkingTime.Text= Prtn.WorkingTime.ToString();
            txtTotalTimeforCoining.Text= Prtn.TotalTimeforCoining.ToString();               

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آيا مايل به ذخيره تغييرات هستيد", "ذخيره سازي", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Prtn.Material = txtMaterial.Text;
                Single.TryParse(txtCoiningWeight.Text, out Prtn.CoiningWeight);
                Single.TryParse(txtInjectionTime.Text, out Prtn.InjectionTime);
                Single.TryParse(txtWaitTimeAfterInjection.Text, out Prtn.WaitTimeAfterInjection);
                Single.TryParse(txtHookWaitTime.Text, out Prtn.HookWaitTime);
                Single.TryParse(txtEjectorTime.Text, out Prtn.EjectorTime);
                int.TryParse(txtHeadTemperature.Text, out Prtn.HeadTemperature);
                int.TryParse(txtMidTemperature.Text, out Prtn.MidTemperature);
                int.TryParse(txtBackTemperature.Text, out Prtn.BackTemperature);
                Single.TryParse(txtFullAutomaticTime.Text, out Prtn.FullAutomaticTime);
                Single.TryParse(txtIntakeTime.Text, out Prtn.IntakeTime);
                Single.TryParse(txtHeadCarriageTime.Text, out Prtn.HeadCarriageTime);
                Single.TryParse(txtBackCarriageTime.Text, out Prtn.BackCarriageTime);
                Single.TryParse(txtWaitTimeBeforeEjector.Text, out Prtn.WaitTimeBeforeEjector);
                Single.TryParse(txtWaitTimeBetweenEjectors.Text, out Prtn.WaitTimeBetweenEjectors);
                int.TryParse(txtEjectorNumber.Text, out Prtn.EjectorNumber);
                Single.TryParse(txtSecondInjectionPressureTime.Text, out Prtn.SecondInjectionPressureTime);
                Single.TryParse(txtPressure.Text, out Prtn.Pressure);
                Single.TryParse(txtWorkingTime.Text, out Prtn.WorkingTime);
                Single.TryParse(txtTotalTimeforCoining.Text, out Prtn.TotalTimeforCoining); 
                

                if (!Prtn.Update()) { MessageBox.Show(Prtn.ErrorMessage); return; };

                this.Close();
            }    

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آيا مايل به حذف ركورد هستيد", "حذف", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (!Prtn.DeleteById()) { MessageBox.Show(Prtn.ErrorMessage); return; };
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmProductionAdd : Form
    {
        Production Prtn = null;
        CastFormat Cf = null;
        Product Pr = null;
        Machine Mc = null;

        public frmProductionAdd()
        {
            InitializeComponent();
        }

        private void frmProductionAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void frmProductionAdd_Load(object sender, EventArgs e)
        {
            // initialize Product
            Pr = new Product();
            DataTable dtp = Pr.GetNamesAll();

            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "ID";
            cbProduct.DataSource = dtp;

            // initialize CastFormat
            Cf = new CastFormat();
            DataTable dtc = Cf.GetNamesAll();

            cbCastFormat.DisplayMember = "Name";
            cbCastFormat.ValueMember = "ID";
            cbCastFormat.DataSource = dtc;

            // initialize Machine
            Mc = new Machine();
            DataTable dtm = Mc.GetNamesAll();

            cbMachine.DisplayMember = "Name";
            cbMachine.ValueMember = "ID";
            cbMachine.DataSource = dtm;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem.ToString() != "")
            {
                Prtn = new Production();

                Prtn.ProductCode = Convert.ToInt64(cbProduct.SelectedValue);
                Prtn.CastCode = Convert.ToInt64(cbCastFormat.SelectedValue);
                Prtn.MachineCode = Convert.ToInt64(cbMachine.SelectedValue);
                              
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
                
                if (!Prtn.Insert()) { MessageBox.Show(Prtn.ErrorMessage); return; };                 

                string msg = "ثبت سفارش {0}  با موفقيت انجام پذيرفت";
                lblMsg.Text = string.Format(msg, cbProduct.SelectedText);
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show(" نام قطعه بايد تعيين گردد ");
            } 

        }

        private void ClearTextBoxes()
        {
            txtMaterial.Text=txtCoiningWeight.Text=txtInjectionTime.Text=txtWaitTimeAfterInjection.Text=txtHookWaitTime.Text=txtEjectorTime.Text=txtHeadTemperature.Text=txtMidTemperature.Text=txtBackTemperature.Text=txtFullAutomaticTime.Text=txtIntakeTime.Text=txtHeadCarriageTime.Text=txtBackCarriageTime.Text=txtWaitTimeBeforeEjector.Text=txtWaitTimeBetweenEjectors.Text=txtEjectorNumber.Text=txtSecondInjectionPressureTime.Text=txtPressure.Text=txtWorkingTime.Text=txtTotalTimeforCoining.Text="";           
                       
        }    

        
    }
}

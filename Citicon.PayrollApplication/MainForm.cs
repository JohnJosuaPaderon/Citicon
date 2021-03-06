﻿using Citicon.Forms;
using Citicon.PayrollIntegration.Forms;
using System;
using System.Windows.Forms;

namespace Citicon.PayrollApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private TimeLogViewForm TimeLogViewForm
        {
            get
            {
                var form = new TimeLogViewForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private UserSettingsForm UserSettingsForm
        {
            get
            {
                var form = new UserSettingsForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private DriverTripReportForm DriverTripReportForm
        {
            get
            {
                var form = new DriverTripReportForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private RouteManagementForm RouteManagementForm
        {
            get
            {
                var form = new RouteManagementForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private TransitMixerManagementForm TransitMixerManagementForm
        {
            get
            {
                var form = new TransitMixerManagementForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private SemiMonthlyPayrollForm SemiMonthlyPayrollForm
        {
            get
            {
                var form = new SemiMonthlyPayrollForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private DriverPayrollForm DriverPayrollForm
        {
            get
            {
                var form = new DriverPayrollForm { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private HolidayManagementForm HolidayManagementForm
        {
            get
            {
                var form = new HolidayManagementForm { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private WeeklyPayrollForm WeeklyPayrollForm
        {
            get
            {
                var form = new WeeklyPayrollForm { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private void OpenMdiChild(Form form)
        {
            if (ActiveMdiChild != null && ActiveMdiChild.GetType() == form.GetType())
            {
                return;
            }
            else
            {
                if (ActiveMdiChild != null)
                {
                    ActiveMdiChild.Close();
                }

                form.Show();
            }
        }

        private void UserSettingsButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(UserSettingsForm);
        }

        private void ViewTimeLogsButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(TimeLogViewForm);
        }

        private void DriverTripReportButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(DriverTripReportForm);
        }

        private void RouteButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(RouteManagementForm);
        }

        private void TransitMixerButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(TransitMixerManagementForm);
        }

        private void SemiMonthlyPayrollButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(SemiMonthlyPayrollForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenMdiChild(TimeLogViewForm);
        }

        private void DriverPayrollButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(DriverPayrollForm);
        }

        private void HolidayButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(HolidayManagementForm);
        }

        private void WeeklyPayrollButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(WeeklyPayrollForm);
        }
    }
}

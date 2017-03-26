﻿using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Controls
{
    public partial class QuotationViewControl : UserControl
    {
        public QuotationViewControl()
        {
            InitializeComponent();
            QuotationChanged += QuotationViewControl_QuotationChanged;
        }

        private async Task GetProjectDesignListAsync()
        {
            ProjectDesignDataGridView.Rows.Clear();
            var projectDesigns = await ProjectDesignManager.
        }

        private async void QuotationViewControl_QuotationChanged(object sender, EventArgs e)
        {
            
        }

        public event EventHandler QuotationChanged;

        private Quotation _Quotation;

        public Quotation Quotation
        {
            get { return _Quotation; }
            set
            {
                if (_Quotation != value)
                {
                    _Quotation = value;
                    OnQuotationChanged();
                }
            }
        }

        protected virtual void OnQuotationChanged()
        {
            QuotationChanged?.Invoke(this, new EventArgs());
        }
    }
}

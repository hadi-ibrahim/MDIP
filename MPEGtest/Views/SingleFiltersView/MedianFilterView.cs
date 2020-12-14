﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPEGtest.ImageFilters;
using MPEGtest.Models;
using MPEGtest.Views.ViewInterfaces;

namespace MPEGtest.Views.SingleFiltersView
{
    public partial class MedianFilterView : Form, ISingleFilterView
    {
        private IImageHandler _imageHandler;
        private int config;
        public MedianFilterView(IImageHandler imageHandler)
        {
            _imageHandler = imageHandler;
            InitializeComponent();
        }


        public void DiscardChanges()
        {
            throw new System.NotImplementedException();
        }

        public void PreviewFilter()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyFilter()
        {
            var image = _imageHandler.GetBitmapImage().ApplyMedianFilter(config);
            applyButton.Enabled  = false;
            _imageHandler.UpdateImage(_imageHandler.GetBitmapImage().ApplyMedianFilter());
            applyButton.Enabled  = true;

        }

        public void SetupInputComponents(SingleFilterConfiguration config)
        {
            throw new System.NotImplementedException();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            config = ValueSlider.Value; 
            // new Thread(() =>
            // {
                ApplyFilter();
            // }).Start();
        }

        private void ValueSlider_Scroll(object sender, EventArgs e)
        {
        }
    }
}
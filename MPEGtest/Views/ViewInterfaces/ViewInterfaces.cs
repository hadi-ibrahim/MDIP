﻿using System;
using System.Threading.Tasks;
using MPEGtest.Models;

namespace MPEGtest.Views.ViewInterfaces
{
    public interface IForm
    {
        public void Show();
        public void Hide();
        // public abstract void SetName();
    }
    public interface IWelcomeView: IForm {}
    public interface IUploadImageView:IForm {}
    public interface ISearchImageView:IForm {}
    public interface IImageFilterView:IForm {}

    public interface ISingleFilterView : IForm
    {
        public void DiscardChanges();
        public void PreviewFilter();
        public void ApplyFilter();
        public void SetupInputComponents(SingleFilterConfiguration config);
    }
    // public interface ISingleFilterView:IForm {}
}
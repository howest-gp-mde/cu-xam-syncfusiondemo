using Syncfusion.XForms.Accordion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SyncFusionDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //based on: https://help.syncfusion.com/xamarin/accordion/getting-started?cs-save-lang=1&cs-lang=xaml
        public MainPage()
        {
            InitializeComponent();
            mySfAccordeon.AnimationDuration = 3000;
            mySfAccordeon.ExpandMode = ExpandMode.Multiple;
        }
    }
}

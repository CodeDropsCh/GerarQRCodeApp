using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace GerarQRCodeApp
{
	public partial class MainPage : ContentPage
	{
        ZXingBarcodeImageView barcode;
        ZXingBarcodeImageView barcode2;

        public MainPage()
		{
			InitializeComponent();


            barcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                AutomationId = "zxingBarcodeImageView",
            };
            barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            barcode.BarcodeOptions.Width = 300;
            barcode.BarcodeOptions.Height = 300;
            barcode.BarcodeOptions.Margin = 10;
            barcode.BarcodeValue = "https://www.youtube.com/channel/UCNQLusaGT0qnCMpK2TBQFAA";


            //this.Content = barcode;
            stackPrinc.Children.Add(barcode);


            barcode2 = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                AutomationId = "zxingBarcodeImageView",
            };
            barcode2.BarcodeFormat = ZXing.BarcodeFormat.EAN_13;
         

            barcode2.BarcodeOptions.Margin = 10;
            barcode2.BarcodeValue = "7898944992122";


            //this.Content = barcode;
            stackPrinc.Children.Add(barcode2);
        }
    }
}

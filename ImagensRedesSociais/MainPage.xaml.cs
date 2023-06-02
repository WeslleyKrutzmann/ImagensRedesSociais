using NativeMedia;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Extensions;

namespace ImagensRedesSociais
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Appearing += this.MainPage_Appearing;
        }

        private void MainPage_Appearing(object sender, EventArgs e)
        {
            this.CheckPermissions();
        }

        private async void CheckPermissions()
        {
            if (await Permissions.CheckStatusAsync<Permissions.StorageRead>() != PermissionStatus.Granted)
            {
                var status = await Permissions.RequestAsync<Permissions.StorageRead>();
            }

            if (await Permissions.CheckStatusAsync<Permissions.StorageWrite>() != PermissionStatus.Granted)
            {
                var status = await Permissions.RequestAsync<Permissions.StorageWrite>();
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.LoadImage();
        }

        private async void LoadImage()
        {
            var results = await MediaGallery.PickAsync(5, MediaFileType.Image);

            if (results?.Files != null)
            {
                foreach (var file in results.Files)
                {
                    var stream = await file.OpenReadAsync();

                    var image = new Image();
                    image.Source = ImageSource.FromStream(() => stream);

                    this.root.Children.Add(image);
                }
            }
        }

        private async void SaveImage(System.IO.Stream stream)
        {
            await MediaGallery.SaveAsync(MediaFileType.Image, stream, "RedesSociais/captura1.jpg");
            await this.DisplayToastAsync("Imagem salva!");
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            this.CaptureImage();
        }

        private async void CaptureImage()
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var result = await MediaPicker.CapturePhotoAsync();
                this.SaveImage(await result.OpenReadAsync());
            }
        }
    }
}

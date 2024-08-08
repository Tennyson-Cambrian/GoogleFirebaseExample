


using Firebase.Storage;

namespace GoogleFirebaseExample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var photo = await MediaPicker.PickPhotoAsync();

            if (photo == null)
            {
                return;
            }
            var task = new FirebaseStorage("class2024-777ce.appspot.com", new FirebaseStorageOptions { ThrowOnCancel = true}).Child(photo.FileName).PutAsync(await photo.OpenReadAsync());
            task.Progress.ProgressChanged += (sender, e) => { progressBar.Progress = e.Percentage; };

            var downloadlink = await task;
            downloadLink.Text = downloadlink;


        }
    }

}

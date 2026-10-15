namespace tenyears;

public partial class NewPage1 : ContentPage
{
    private int age;
	public NewPage1()
	{
		InitializeComponent();
	}


    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        age = (int)sliderAge.Value ;
        entryAge.Text = age.ToString();
        age += 10;
    }

    private void sliderAge_DragCompleted(object sender, EventArgs e)
    {
        lableResult.Text = "Helllo " + entryName.Text + " you will be " + age + " in ten years";
    }
}
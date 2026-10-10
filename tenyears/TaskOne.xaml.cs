namespace tenyears;

public partial class TaskOne : ContentPage
{
	public TaskOne()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int age;
        if(!int.TryParse(entryAge.Text, out age))
        {
            lableResult.Text = "Please enter valid age";
            return;
        }
        age += 10;
        lableResult.Text = "Helllo " + entryName.Text + " you will be " + age + " in ten years";    
    }
}
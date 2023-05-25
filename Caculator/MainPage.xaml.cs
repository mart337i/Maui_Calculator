namespace Caculator;

public partial class MainPage : ContentPage
{
    string calculated_string;
    int calc_state = 0;

	public MainPage()
	{
		InitializeComponent();
        onClear(this, null); 
	}

	void onClear(object sender, EventArgs e)
	{
        calculated_string = "0";
        this.result.Text = calculated_string;
	}

    void onSquareRoot(object sender, EventArgs e)
    {
        var calculated_double = Convert.ToDouble(calculated_string.Replace(".", ","));

        calculated_string = Math.Sqrt(calculated_double).ToString(); 
        this.result.Text = calculated_string;
    }

    void onNumberSelection(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string bntPressed = button.Text;

        if (calc_state == 1)
        {
            this.result.Text = string.Empty;
            calculated_string = string.Empty;
            calc_state = 0;
        }


        if(this.result.Text == "0")
        {
            this.result.Text = string.Empty;
            calculated_string = string.Empty;
        }

        calculated_string += bntPressed;
        this.result.Text += bntPressed;

    }

    void onOperatorSelection(object sender, EventArgs e)
    {
        if (calc_state == 1)
        {
            calc_state = 0;
        }

        Button button = (Button)sender;
        string bntPressed = button.Text;
        calculated_string += bntPressed;
        this.result.Text = calculated_string;
    }

    void onCalculate(object sender, EventArgs e)
    {
      
        var resualt = Calculator.DoCalculation(calculated_string);
        this.result.Text = resualt.ToString();
        calculated_string = resualt;
        calc_state = 1;
    }

}


using System;

namespace events
{
    public class ButtonEventArgs : EventArgs
    {
        public string ButtonText { get; set; }
    } 
}

public class ButtonEventArgs
{
    public event EventHandler<ButtonEventArgs> Clicked;

    private string _text;
    public string Text
    {
        get { return _text; }
        set
        {
            _text = value;
            if (Clicked != null)
            {
                Clicked(this, new ButtonEventArgs { ButtonText = _text });
            }
        }
    }
}

private void OnTextClicked(object sender, ButtonEventArgs e)
{
    Console.WriteLine("Button clicked: " + e.ButtonText);
}

public void Clicked()
{
    Text = "Clicked";
}

class Program
{
    static void Main(string[] args)
    {
        Button button = new Button();
        button.Text = "Click me";

        button.Clicked += OnTextClicked;
        button.Clicked();
    }

    static void OnTextClicked(object sender, ButtonEventArgs e)
    {
        Console.WriteLine("Button clicked: " + e.ButtonText);
    }

    static void OnTextClicked2(object sender, ButtonEventArgs e)
    {
        Console.WriteLine("Button2 clicked: " + e.ButtonText);
    }
}
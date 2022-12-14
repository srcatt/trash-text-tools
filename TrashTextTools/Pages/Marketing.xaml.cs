using System;
using System.Windows;
using System.Windows.Controls;
using Wpf.Ui.Controls;

namespace TrashTextTools.Pages;

public partial class Marketing : UiPage
{
    public Marketing()
    {
        InitializeComponent();
    }

    private void OnGenerateClick(object sender, RoutedEventArgs e)
    {
        string result =
            String.Format(
                "{0}{1}是怎么回事呢？{0}相信大家都很熟悉，但是{0}{1}是怎么回事呢，下面就让小编带大家一起了解吧。{0}{1}，其实就是{2}，大家可能会很惊讶{0}怎么会{1}呢？但事实就是这样，小编也感到非常惊讶。这就是关于{0}{1}的事情了，大家有什么想法呢，欢迎在评论区告诉小编一起讨论哦！",
                SubjectTextBox.Text, EventTextBox.Text, AltTextBox.Text);
        ResultTextBlock.Text = result;
    }
}
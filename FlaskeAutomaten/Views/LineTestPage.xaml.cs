using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlaskeAutomaten.Views
{
    /// <summary>
    /// Interaction logic for LineTestPage.xaml
    /// </summary>
    public partial class LineTestPage : Page
    {
        public LineTestPage()
        {
            InitializeComponent();
            PointAnimationExample();


        }
        public void PointAnimationExample()
        {
            // Create a NameScope for this page so that
            // Storyboards can be used.
            NameScope.SetNameScope(this, new NameScope());

            EllipseGeometry myEllipseGeometry = new EllipseGeometry();
            myEllipseGeometry.Center = new Point(100, 100);
            myEllipseGeometry.RadiusX = 5;
            myEllipseGeometry.RadiusY = 5;

            // Assign the EllipseGeometry a name so that
            // it can be targeted by a Storyboard.
            this.RegisterName(
                "MyAnimatedEllipseGeometry", myEllipseGeometry);

            Path myPath = new Path();
            myPath.Fill = Brushes.Blue;
            myPath.Margin = new Thickness(15);
            myPath.Data = myEllipseGeometry;

            PointAnimation myPointAnimation = new PointAnimation();
            myPointAnimation.Duration = TimeSpan.FromSeconds(2);

            // Set the animation to repeat forever. 
            myPointAnimation.RepeatBehavior = RepeatBehavior.Forever;

            // Set the From and To properties of the animation.
            myPointAnimation.From = new Point(100, 100);
            myPointAnimation.To = new Point(300, 100);

            // Set the animation to target the Center property
            // of the object named "MyAnimatedEllipseGeometry."
            Storyboard.SetTargetName(myPointAnimation, "MyAnimatedEllipseGeometry");
            Storyboard.SetTargetProperty(
                myPointAnimation, new PropertyPath(EllipseGeometry.CenterProperty));

            // Create a storyboard to apply the animation.
            Storyboard ellipseStoryboard = new Storyboard();
            ellipseStoryboard.Children.Add(myPointAnimation);

            // Start the storyboard when the Path loads.
            myPath.Loaded += delegate (object sender, RoutedEventArgs e)
            {
                ellipseStoryboard.Begin(this);
            };

            Canvas containerCanvas = new Canvas();
            containerCanvas.Children.Add(myPath);

            Content = containerCanvas;
        }

    }
}

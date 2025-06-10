namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        private readonly FreeHandDrawable _freeHandDrawable;

        public MainPage()
        {
            InitializeComponent();
            _freeHandDrawable = new FreeHandDrawable();
            _graphicsView.Drawable = _freeHandDrawable;
        }

        private void _graphicsView_StartInteraction(object sender, TouchEventArgs e)
        {
            var touchPoint = e.Touches[0];  
            _freeHandDrawable.setTouchPoint(touchPoint);
            _graphicsView.Invalidate();
        }

        private void _graphicsView_DragInteraction(object sender, TouchEventArgs e)
        {

        }

        private void _graphicsView_EndInteraction(object sender, TouchEventArgs e)
        {

        }


    }

}

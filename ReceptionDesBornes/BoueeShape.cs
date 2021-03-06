﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

using ReceptionDesBornesModele;

namespace ReceptionDesBornes
{
    class BoueeShape : Shape
    {
        EllipseGeometry ellipse;
        Bouee bouee;
        public static readonly DependencyProperty TextBoxRProperty = DependencyProperty.Register("TextBoxR", typeof(TextBox), typeof(BoueeShape), new FrameworkPropertyMetadata(null));

        public TextBox TextBox
        {
            get { return (TextBox)GetValue(TextBoxRProperty); }
            set { SetValue(TextBoxRProperty, value); }
        }

        public BoueeShape(Bouee bouee)
        {
            ellipse = new EllipseGeometry();
            this.bouee = bouee;

            this.Width = 10;
            this.Height = 10;
            this.Stroke = Brushes.Black;
            this.StrokeThickness = 10;
        }

        protected override Geometry DefiningGeometry
        {
            get
            {
                TranslateTransform t = new TranslateTransform(ActualWidth / 2, ActualHeight / 2);
                ellipse.Transform = t;
                ellipse.RadiusX = this.ActualWidth / 2;
                ellipse.RadiusY = this.ActualHeight / 2;
                return ellipse;
            }
        }

        public Bouee Bouee
        {
            get
            {
                return bouee;
            }
        }
    }
}

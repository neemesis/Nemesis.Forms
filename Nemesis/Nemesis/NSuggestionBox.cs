﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace Nemesis {
    public class NSuggestionBox : View {

        /// <summary>
        /// 
        /// </summary>

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text",
                typeof(string),
                typeof(NSuggestionBox),
                default(string), 
                BindingMode.TwoWay);

        public string Text {
            get { return (string)GetValue(TextProperty); }
            set {
                SetValue(TextProperty, value);
                if (TextProperty != null)
                    TextChanged?.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler<EventArgs> TextChanged;

        private static void OnTextChanged(BindableObject bindable, object oldvalue, object newvalue) {
            var suggestionBox = (NSuggestionBox)bindable;
            suggestionBox.Text = (string)newvalue;
        }

        /// <summary>
        /// 
        /// </summary>

        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(
                propertyName: "ItemsSource",
                returnType: typeof(ObservableCollection<string>),
                declaringType: typeof(NSuggestionBox),
                defaultValue: new ObservableCollection<string>(),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnItemsSourceChanged);

        public ObservableCollection<string> ItemsSource {
            get { return (ObservableCollection<string>)GetValue(ItemsSourceProperty); }
            set {
                SetValue(ItemsSourceProperty, value);
                if (ItemsSourceProperty != null)
                    ItemsSourceChanged?.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler<EventArgs> ItemsSourceChanged;

        private static void OnItemsSourceChanged(BindableObject bindable, object oldvalue, object newvalue) {
            var suggestionBox = (NSuggestionBox)bindable;
            suggestionBox.ItemsSource = (ObservableCollection<string>) newvalue;
        }

        /// <summary>
        /// 
        /// </summary>

        public static readonly BindableProperty SelectedTextProperty =
            BindableProperty.Create("SelectedText",
                typeof(string),
                typeof(NSuggestionBox),
                default(string),
                BindingMode.TwoWay);

        public string SelectedText {
            get { return (string)GetValue(SelectedTextProperty); }
            set {
                Debug.WriteLine("SetSelectedText: " + value);
                SetValue(SelectedTextProperty, value);
                if (SelectedTextProperty != null)
                    SelectedTextChanged?.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler<EventArgs> SelectedTextChanged;

        private static void OnSelectedTextChanged(BindableObject bindable, object oldvalue, object newvalue) {
            var suggestionBox = (NSuggestionBox)bindable;
            suggestionBox.SelectedText = (string)newvalue;
        }
    }
}
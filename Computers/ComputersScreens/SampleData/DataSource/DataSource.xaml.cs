﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.DataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class DataSource { }
#else

	public class DataSource : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public DataSource()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/Computers.Screens;component/SampleData/DataSource/DataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private ItemCollection _Collection = new ItemCollection();

		public ItemCollection Collection
		{
			get
			{
				return this._Collection;
			}
		}

		private Collection1ItemCollection _Collection1 = new Collection1ItemCollection();

		public Collection1ItemCollection Collection1
		{
			get
			{
				return this._Collection1;
			}
		}

		private Collection2ItemCollection _Collection2 = new Collection2ItemCollection();

		public Collection2ItemCollection Collection2
		{
			get
			{
				return this._Collection2;
			}
		}
	}

	public class Item : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private System.Windows.Media.ImageSource _Image = null;

		public System.Windows.Media.ImageSource Image
		{
			get
			{
				return this._Image;
			}

			set
			{
				if (this._Image != value)
				{
					this._Image = value;
					this.OnPropertyChanged("Image");
				}
			}
		}

		private double _Price = 0;

		public double Price
		{
			get
			{
				return this._Price;
			}

			set
			{
				if (this._Price != value)
				{
					this._Price = value;
					this.OnPropertyChanged("Price");
				}
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}
	}

	public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
	{ 
	}

	public class Collection1Item : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private System.Windows.Media.ImageSource _Computer = null;

		public System.Windows.Media.ImageSource Computer
		{
			get
			{
				return this._Computer;
			}

			set
			{
				if (this._Computer != value)
				{
					this._Computer = value;
					this.OnPropertyChanged("Computer");
				}
			}
		}

		private System.Windows.Media.ImageSource _Component = null;

		public System.Windows.Media.ImageSource Component
		{
			get
			{
				return this._Component;
			}

			set
			{
				if (this._Component != value)
				{
					this._Component = value;
					this.OnPropertyChanged("Component");
				}
			}
		}
	}

	public class Collection1ItemCollection : System.Collections.ObjectModel.ObservableCollection<Collection1Item>
	{ 
	}

	public class Collection2Item : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private System.Windows.Media.ImageSource _comp1 = null;

		public System.Windows.Media.ImageSource comp1
		{
			get
			{
				return this._comp1;
			}

			set
			{
				if (this._comp1 != value)
				{
					this._comp1 = value;
					this.OnPropertyChanged("comp1");
				}
			}
		}
	}

	public class Collection2ItemCollection : System.Collections.ObjectModel.ObservableCollection<Collection2Item>
	{ 
	}
#endif
}

using BleakwindBuffet.Data.Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data {
    public class Order : ICollection, INotifyPropertyChanged, INotifyCollectionChanged {
        /// <summary>
        /// number of items in the colleciton
        /// </summary>
        public int Count {
            get { return items.Count; }
        }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot {
            get { return this; }
        }

        /// <summary>
        /// holds all the items in the order collection
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        public List<IOrderItem> Items {
            get {
                return items;
            }
        }

        private static uint OrderNumber = 1;

        /// <summary>
        /// holds the tax rate for the order
        /// </summary>
        public double SalesTaxRate { get; set; } = .12;

        /// <summary>
        /// holds the specific order number for this order
        /// </summary>
        public uint Number { get; private set; }

        /// <summary>
        /// Order number displayed as a string for binding
        /// </summary>
        public string OrderNumberString {
            get { return $"Order #{Number}"; }
        }

        /// <summary>
        /// gets the subtotal of all items in order
        /// </summary>
        public double Subtotal { 
            get {
                double total = 0;
                foreach (IOrderItem item in items) {
                    total += item.Price;
                }
                return Math.Round(total, 2);
            }
        }

        /// <summary>
        /// calculates tax of order using subtotal and sales tax rate
        /// </summary>
        public double Tax {
            get { return Math.Round((Subtotal * SalesTaxRate), 2) ; }
        }

        /// <summary>
        /// gets the total price of the order
        /// </summary>
        public double Total {
            get { return Math.Round((Subtotal + Tax), 2); }
        }

        /// <summary>
        /// gets the total calories of the order
        /// </summary>
        public double Calories {
            get {
                uint total = 0;
                foreach (IOrderItem item in items) {
                    total += item.Calories;
                }
                return total;
            }
        }

        public Order() {
            Number = OrderNumber;
            OrderNumber++;
        }

        /// <summary>
        /// adds an item to the order
        /// </summary>
        /// <param name="item">IOrderItem to be added to the order</param>
        public void Add(IOrderItem item) {
            item.PropertyChanged += ItemPropertyChangedListener;
            items.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// removes an item from the order
        /// </summary>
        /// <param name="item">IOrderItem to be removed from the order</param>
        public void Remove(IOrderItem item) {
            item.PropertyChanged -= ItemPropertyChangedListener;
            items.Remove(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, 0));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// signals when properties have been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// signals when the collection has changed
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        void ItemPropertyChangedListener(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == "Price") { 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            if (e.PropertyName == "Calories") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        public void CopyTo(Array array, int index) {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator() {
            return items.GetEnumerator();
        }
    }
}

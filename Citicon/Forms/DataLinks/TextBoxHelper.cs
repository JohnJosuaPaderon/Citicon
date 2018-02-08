using System;
using System.Windows.Forms;

namespace Citicon.Forms.DataLinks
{
    public sealed class TextBoxHelper<TResult> : IDisposable
    {
        public static TextBoxHelper<decimal> CurrencyHelper(TextBox textBox, bool listenAccept = true, Action<decimal> accept = null)
        {
            return new TextBoxHelper<decimal>(textBox, listenAccept: listenAccept, accept: accept, format: FormatCurrency, parse: ParseCurrency);
        }

        private static string FormatCurrency(string text)
        {
            decimal.TryParse(text, out decimal result);
            return result.ToString(Resources.Formats.Currency);
        }

        private static decimal ParseCurrency(string text)
        {
            decimal.TryParse(text.Replace(",", string.Empty), out decimal result);
            return result;
        }

        public TextBoxHelper(TextBox textBox, bool listenAccept = false, Action<TResult> accept = null, Func<string, string> format = null, Func<string, TResult> parse = null)
        {
            _TextBox = textBox ?? throw new ArgumentNullException(nameof(textBox));
            _ListenAccept = listenAccept;
            _Format = format;
            _Parse = parse;

            if (_ListenAccept)
            {
                _TextBox.KeyDown += KeyDown;
                _Accept = accept;
            }

            _TextBox.Leave += Leave;
        }

        private readonly TextBox _TextBox;
        private readonly bool _ListenAccept;
        private readonly Action<TResult> _Accept;
        private readonly Func<string, TResult> _Parse;
        private readonly Func<string, string> _Format;

        public void Dispose()
        {
            if (_ListenAccept)
            {
                _TextBox.KeyDown += KeyDown;
            }
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TryAccept();
                TryFormat();
            }
        }

        private void Leave(object sender, EventArgs e)
        {
            TryAccept();
            TryFormat();
        }

        private void TryAccept()
        {
            if (_ListenAccept)
            {
                _Accept(_Parse(_TextBox.Text));
            }
        }

        private void TryFormat()
        {
            _TextBox.Text = _Format?.Invoke(_TextBox.Text);
        }
    }
}

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FRLF.Views
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "4.0.3.214")]
public partial class RazorView : RazorViewBase
{

#line hidden

#line 1 "RazorView.cshtml"
public FRLF.Models.HomeModel Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<!--\r\nFRLF, built by Loren Kuich, Jun 2016    \r\n-->\r\n\r\n<html>\r\n<head>\r\n    <!-- J" +
"Query, Bootstrap, font, animate -->\r\n    <script");

WriteLiteral(" src=\"https://code.jquery.com/jquery-2.2.4.min.js\"");

WriteLiteral(" integrity=\"sha256-BbhdlvQf/xTY9gja0Dq3HiwQF8LaCRTXxZKRutelT44=\"");

WriteLiteral(" crossorigin=\"anonymous\"");

WriteLiteral("></script>\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css\"");

WriteLiteral(" integrity=\"sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkz" +
"s7\"");

WriteLiteral(" crossorigin=\"anonymous\"");

WriteLiteral(">\r\n    <script");

WriteLiteral(" src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js\"");

WriteLiteral(" integrity=\"sha384-0mSbJDEHialfmuBBQP6A4Qrprq5OVfW37PRR3j5ELqxss1yVqOtnepnHVP9aJ7" +
"xS\"");

WriteLiteral(" crossorigin=\"anonymous\"");

WriteLiteral("></script>\r\n    <link");

WriteLiteral(" href=\'https://fonts.googleapis.com/css?family=Open+Sans\'");

WriteLiteral(" rel=\'stylesheet\'");

WriteLiteral(" type=\'text/css\'");

WriteLiteral(">\r\n    \r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"js/main.js\"");

WriteLiteral("></script>\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"css/animate.css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"css/style.css\"");

WriteLiteral(" />\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var view = ");


#line 21 "RazorView.cshtml"
                  Write(Model.View);


#line default
#line hidden
WriteLiteral(@";
            showView(view);
            
            if (currentGrid === 2)
                codeLen = 3;

            $(""#CodeEntry"").keyup(function(event) {
                if (event.keyCode == 13)
                    onCodeSubmit();
            });
        });
    </script>

</head>
<body>
    <form>
        <div");

WriteLiteral(" id=\"host\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"login\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"animated fadeIn\"");

WriteLiteral(">Enter a compound</h1>\r\n                <br />\r\n                <input");

WriteLiteral(" class=\"form-control animated fadeInUp\"");

WriteLiteral(" id=\"CodeEntry\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" />\r\n                <button");

WriteLiteral(" id=\"submitCode\"");

WriteLiteral(" class=\"btn btn-default btn-lg btn-primary animated fadeInUp\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" onclick=\"onCodeSubmit()\"");

WriteLiteral(">Submit</button>\r\n                <br />\r\n                <br />\r\n               " +
" <h3");

WriteLiteral(" id=\"error-code\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral(">Incorrect compound</h3>\r\n                <h3");

WriteLiteral(" id=\"loading-code\"");

WriteLiteral(" style=\"color: orange;\"");

WriteLiteral(">Loading PowerPoint...</h3>\r\n\r\n                <div");

WriteLiteral(" id=\"cr\"");

WriteLiteral("><h4");

WriteLiteral(" class=\"animated fadeIn\"");

WriteLiteral("><i><a");

WriteLiteral(" href=\"http://lkuich.com\"");

WriteLiteral(">Loren Kuich - 2016</a></i></h4></div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(" id=\"grid1\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"animated fadeIn\"");

WriteLiteral(">Enter Punch Code</h2>\r\n                <br />\r\n                <br />\r\n         " +
"       <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row1\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn1\"");

WriteLiteral(">\r\n                        <h2>1</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn2\"");

WriteLiteral(">\r\n                        <h2>2</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn3\"");

WriteLiteral(">\r\n                        <h2>3</h2>\r\n                    </div>\r\n              " +
"  </div>\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row2\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnCloud\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/Cloud.png\"");

WriteLiteral(" style=\"padding-top: 10px;\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn5\"");

WriteLiteral(">\r\n                        <h2>5</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnSun\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/Sun.png\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn7\"");

WriteLiteral(">\r\n                        <h2>7</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn8\"");

WriteLiteral(">\r\n                        <h2>8</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn9\"");

WriteLiteral(">\r\n                        <h2>9</h2>\r\n                    </div>\r\n              " +
"  </div>\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row4\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnLightning\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/Lightning.png\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn0\"");

WriteLiteral(">\r\n                        <h2>0</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnWind\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/Wind.png\"");

WriteLiteral(" style=\"height: 100%; width: auto;\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n" +
"            <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(" id=\"grid2\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"animated fadeIn\"");

WriteLiteral(">Enter Punch Code</h2>\r\n                <br />\r\n                <br />\r\n         " +
"       <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row1\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn1\"");

WriteLiteral(">\r\n                        <h2>1</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn2\"");

WriteLiteral(">\r\n                        <h2>2</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn3\"");

WriteLiteral(">\r\n                        <h2>3</h2>\r\n                    </div>\r\n              " +
"  </div>\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row2\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnString\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/String.png\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn5\"");

WriteLiteral(">\r\n                        <h2>5</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnFlammable\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/Flammable.png\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn7\"");

WriteLiteral(">\r\n                        <h2>7</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn8\"");

WriteLiteral(">\r\n                        <h2>8</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn9\"");

WriteLiteral(">\r\n                        <h2>9</h2>\r\n                    </div>\r\n              " +
"  </div>\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row4\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnId\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/ID.png\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn0\"");

WriteLiteral(">\r\n                        <h2>0</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnRadioactive\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/Radioactive.png\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n" +
"            <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(" id=\"grid3\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"animated fadeIn\"");

WriteLiteral(">Enter Punch Code</h2>\r\n                <br />\r\n                <br />\r\n         " +
"       <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row1\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn1\"");

WriteLiteral(">\r\n                        <h2>1</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn2\"");

WriteLiteral(">\r\n                        <h2>2</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn3\"");

WriteLiteral(">\r\n                        <h2>3</h2>\r\n                    </div>\r\n              " +
"  </div>\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row2\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnPastDue\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/Past_Due.png\"");

WriteLiteral(" style=\"padding-top: 10px;\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn5\"");

WriteLiteral(">\r\n                        <h2>5</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnCash\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/Cash.png\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn7\"");

WriteLiteral(">\r\n                        <h2>7</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn8\"");

WriteLiteral(">\r\n                        <h2>8</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn9\"");

WriteLiteral(">\r\n                        <h2>9</h2>\r\n                    </div>\r\n              " +
"  </div>\r\n\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"row4\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnPhone\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/iPhone.png\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btn0\"");

WriteLiteral(">\r\n                        <h2>0</h2>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-xs-4 col-md-4\"");

WriteLiteral(" id=\"btnWallet\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" src=\"img/Wallet.png\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n  " +
"          <br />\r\n            <h3");

WriteLiteral(" id=\"valid-grid\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral(">Success!<br />Loading PowerPoint...</h3>\r\n            <h3");

WriteLiteral(" id=\"invalid-grid\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral(">Incorrect Entry, try again!</h3>\r\n        </div>\r\n    </form>\r\n</body>\r\n</html>");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class RazorViewBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591

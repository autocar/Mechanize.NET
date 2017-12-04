﻿using HtmlAgilityPack;

namespace Mechanize.Forms.Controls.Options
{
    /// <summary>
    /// The Base ListOption definition, for an option in a <see cref="ListControl"/>.
    /// </summary>
    public abstract class ListOption
    {
        internal ListOption(ListControl Parent, HtmlNode Node)
        {
            this.Parent = Parent;
            this.Node = Node;
        }

        /// <summary>
        /// The Html "id" attribute for this option.
        /// </summary>
        public string ID => Node.GetAttributeValue("id", null);

        /// <summary>
        /// The Html "name" attribute for this option.
        /// </summary>
        public virtual string Name => Node.InnerText;

        /// <summary>
        /// The Html "value" attribute for this option.
        /// </summary>
        public virtual string Value => Node.GetAttributeValue("value", null);

        /// <summary>
        /// The Html "label" attribute for this option.
        /// </summary>
        public virtual string Label => Node.GetAttributeValue("label", null);

        /// <summary>
        /// The Value used for creating the Submission form.
        /// </summary>
        public virtual string TransmitValue => Value;

        /// <summary>
        /// Determines if the current Option is selected.
        /// </summary>
        public virtual bool Selected { get; set; }

        /// <summary>
        /// The Underlying node for this option.
        /// </summary>
        public readonly HtmlNode Node;

        /// <summary>
        /// The Parent control that this Option belongs to.
        /// </summary>
        public readonly ListControl Parent;
    }
}
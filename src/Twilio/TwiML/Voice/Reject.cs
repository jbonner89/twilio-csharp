/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Types;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Reject TwiML Verb
    /// </summary>
    public class Reject : TwiML 
    {
        public sealed class ReasonEnum : StringEnum 
        {
            private ReasonEnum(string value) : base(value) {}
            public ReasonEnum() {}
            public static implicit operator ReasonEnum(string value)
            {
                return new ReasonEnum(value);
            }

            public static readonly ReasonEnum Rejected = new ReasonEnum("rejected");
            public static readonly ReasonEnum Busy = new ReasonEnum("busy");
        }

        /// <summary>
        /// Rejection reason
        /// </summary>
        public Reject.ReasonEnum Reason { get; set; }

        /// <summary>
        /// Create a new Reject
        /// </summary>
        /// <param name="reason"> Rejection reason </param>
        public Reject(Reject.ReasonEnum reason = null) : base("Reject")
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Reason != null)
            {
                attributes.Add(new XAttribute("reason", this.Reason.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Reject Append(TwiML childElem)
        {
            return (Reject) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Reject SetOption(string key, object value)
        {
            return (Reject) base.SetOption(key, value);
        }
    }

}
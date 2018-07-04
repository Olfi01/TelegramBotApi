﻿using Newtonsoft.Json;

namespace TelegramBotApi.Types.Markup
{
    /// <summary>
    /// This object represents one button of the reply keyboard. 
    /// For simple text buttons String can be used instead of this object to specify text of the button. Optional fields are mutually exclusive.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, ItemNullValueHandling = NullValueHandling.Ignore)]
    public class KeyboardButton
    {
        /// <summary>
        /// Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed
        /// </summary>
        [JsonProperty(PropertyName = "text", Required = Required.Always)]
        public string Text { get; set; }

        /// <summary>
        /// Optional. If True, the user's phone number will be sent as a contact when the button is pressed. Available in private chats only
        /// </summary>
        [JsonProperty(PropertyName = "request_contact")]
        public bool RequestContact { get; set; }

        /// <summary>
        /// Optional. If True, the user's current location will be sent when the button is pressed. Available in private chats only
        /// </summary>
        [JsonProperty(PropertyName = "request_location")]
        public bool RequestLocation { get; set; }

        /// <summary>
        /// Initializes a new, empty instance of the <see cref="KeyboardButton"/> class. Has to be filled with data.
        /// </summary>
        public KeyboardButton()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardButton"/> class
        /// </summary>
        /// <param name="text">The text on the button (will be sent when it is clicked)</param>
        public KeyboardButton(string text)
        {
            Text = text;
        }
    }
}

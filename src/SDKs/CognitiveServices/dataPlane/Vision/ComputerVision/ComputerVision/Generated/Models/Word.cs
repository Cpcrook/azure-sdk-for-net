// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Json object representing a recognized word.
    /// </summary>
    public partial class Word
    {
        /// <summary>
        /// Initializes a new instance of the Word class.
        /// </summary>
        public Word()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Word class.
        /// </summary>
        /// <param name="boundingBox">Bounding box of a recognized
        /// word.</param>
        /// <param name="text">The text content of the word.</param>
        /// <param name="confidence">Qualitative confidence measure. Possible
        /// values include: 'High', 'Low'</param>
        public Word(IList<dynamic> boundingBox, string text, TextRecognitionResultConfidenceClass? confidence = default(TextRecognitionResultConfidenceClass?))
        {
            BoundingBox = boundingBox;
            Text = text;
            Confidence = confidence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets bounding box of a recognized word.
        /// </summary>
        [JsonProperty(PropertyName = "boundingBox")]
        public IList<dynamic> BoundingBox { get; set; }

        /// <summary>
        /// Gets or sets the text content of the word.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets qualitative confidence measure. Possible values
        /// include: 'High', 'Low'
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public TextRecognitionResultConfidenceClass? Confidence { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BoundingBox == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BoundingBox");
            }
            if (Text == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Text");
            }
        }
    }
}

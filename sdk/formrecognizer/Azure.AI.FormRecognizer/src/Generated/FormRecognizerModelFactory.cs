// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.FormRecognizer.Training;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class FormRecognizerModelFactory
    {

        /// <summary> Initializes new instance of CustomFormModelInfo class. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="status"> Status of the model. </param>
        /// <param name="trainingStartedOn"> Date and time (UTC) when the model was created. </param>
        /// <param name="trainingCompletedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="modelName"> Optional user defined model name (max length: 1024). </param>
        /// <param name="properties"> Optional model attributes. </param>
        /// <returns> A new <see cref="Training.CustomFormModelInfo"/> instance for mocking. </returns>
        public static CustomFormModelInfo CustomFormModelInfo(string modelId = default, CustomFormModelStatus status = default, DateTimeOffset trainingStartedOn = default, DateTimeOffset trainingCompletedOn = default, string modelName = default, CustomFormModelProperties properties = default)
        {
            return new CustomFormModelInfo(modelId, status, trainingStartedOn, trainingCompletedOn, modelName, properties);
        }

        /// <summary> Initializes new instance of TrainingDocumentInfo class. </summary>
        /// <param name="name"> Training document name. </param>
        /// <param name="pageCount"> Total number of pages trained. </param>
        /// <param name="errors"> List of errors. </param>
        /// <param name="status"> Status of the training operation. </param>
        /// <returns> A new <see cref="Training.TrainingDocumentInfo"/> instance for mocking. </returns>
        public static TrainingDocumentInfo TrainingDocumentInfo(string name = default, int pageCount = default, IReadOnlyList<FormRecognizerError> errors = default, TrainingStatus status = default)
        {
            errors ??= new List<FormRecognizerError>();
            return new TrainingDocumentInfo(name, pageCount, errors, status);
        }

        /// <summary> Initializes new instance of CustomFormModelField class. </summary>
        /// <param name="name"> Training field name. </param>
        /// <param name="accuracy"> Estimated extraction accuracy for this field. </param>
        /// <returns> A new <see cref="Training.CustomFormModelField"/> instance for mocking. </returns>
        public static CustomFormModelField CustomFormModelField(string name = default, float? accuracy = default)
        {
            return new CustomFormModelField(name, accuracy);
        }
    }
}

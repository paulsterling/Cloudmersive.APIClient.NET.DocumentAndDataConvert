/* 
 * convertapi
 *
 * Convert API lets you effortlessly convert file formats and types.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Cloudmersive.APIClient.NET.DocumentAndDataConvert.Test
{
    /// <summary>
    ///  Class for testing ConvertDocumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConvertDocumentApiTests
    {
        private ConvertDocumentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConvertDocumentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConvertDocumentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConvertDocumentApi
            //Assert.IsInstanceOfType(typeof(ConvertDocumentApi), instance, "instance is a ConvertDocumentApi");
        }

        
        /// <summary>
        /// Test ConvertDocumentAutodetectGetInfo
        /// </summary>
        [Test]
        public void ConvertDocumentAutodetectGetInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentAutodetectGetInfo(inputFile);
            //Assert.IsInstanceOf<AutodetectGetInfoResult> (response, "response is AutodetectGetInfoResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentAutodetectToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentAutodetectToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentAutodetectToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentCsvToXlsx
        /// </summary>
        [Test]
        public void ConvertDocumentCsvToXlsxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentCsvToXlsx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentDocToDocx
        /// </summary>
        [Test]
        public void ConvertDocumentDocToDocxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentDocToDocx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentDocToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentDocToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentDocToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentDocxToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentDocxToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentDocxToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPdfToPngArray
        /// </summary>
        [Test]
        public void ConvertDocumentPdfToPngArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPdfToPngArray(inputFile);
            //Assert.IsInstanceOf<PdfToPngResult> (response, "response is PdfToPngResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentPptToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentPptToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPptToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPptToPptx
        /// </summary>
        [Test]
        public void ConvertDocumentPptToPptxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPptToPptx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPptxToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentPptxToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPptxToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentXlsToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentXlsToPdf(inputFile);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsToXlsx
        /// </summary>
        [Test]
        public void ConvertDocumentXlsToXlsxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentXlsToXlsx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsxToCsv
        /// </summary>
        [Test]
        public void ConvertDocumentXlsxToCsvTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentXlsxToCsv(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsxToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentXlsxToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentXlsxToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}

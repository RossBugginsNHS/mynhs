/*
 * My NHS Graph
 *
 * WIP Strawman API ideas for a Unified API myNHS API Graph endpoint, bringing together both new \"User Generated Data\" and existing sources into one endpoint and one Authorisation model, supporting delegated user access and proxy access. Modeling that the records belong to the \"tennant\" with owners having proxy access (ie full) and users being shared specifics records. Oauth scopes, with modifiers of .shared and .all. Look at Microsoft Graph for where that comes from. To support idempotency, all POST apis are just requests to start something, the put starts this. Alows for evential consistency. Long running GETs are removed, by POSTing requests for data, with a GET endpoint returned.
 *
 * OpenAPI spec version: 0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using mynhs.Attributes;
using mynhs.Security;
using Microsoft.AspNetCore.Authorization;
using mynhs.Models;

namespace mynhs.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class MedicalRecordsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">The User Id to access</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/medicalrecords/detailed/nhs/requestRecords")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(MyNhsProfile), description: "OK")]
        public virtual IActionResult MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsPost([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MyNhsProfile));
            string exampleJson = null;
            exampleJson = "{\n  \"GpProfile\" : {\n    \"GpIdCode\" : 0\n  },\n  \"NHSProfile\" : {\n    \"NhsNumber\" : 0\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MyNhsProfile>(exampleJson)
                        : default(MyNhsProfile);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">The User Id to access</param>
        /// <param name="requestId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/medicalrecords/detailed/nhs/requestRecords/{requestId}")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(MyNhsProfile), description: "OK")]
        public virtual IActionResult MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdGet([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId, [FromRoute][Required]string requestId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MyNhsProfile));
            string exampleJson = null;
            exampleJson = "{\n  \"GpProfile\" : {\n    \"GpIdCode\" : 0\n  },\n  \"NHSProfile\" : {\n    \"NhsNumber\" : 0\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MyNhsProfile>(exampleJson)
                        : default(MyNhsProfile);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">The User Id to access</param>
        /// <param name="requestId"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/medicalrecords/detailed/nhs/requestRecords/{requestId}/submit")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(MyNhsProfile), description: "OK")]
        public virtual IActionResult MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId, [FromRoute][Required]string requestId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MyNhsProfile));
            string exampleJson = null;
            exampleJson = "{\n  \"GpProfile\" : {\n    \"GpIdCode\" : 0\n  },\n  \"NHSProfile\" : {\n    \"NhsNumber\" : 0\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MyNhsProfile>(exampleJson)
                        : default(MyNhsProfile);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">The User Id to access</param>
        /// <param name="resultId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/medicalrecords/detailed/nhs/requestRecords/results/{resultId}")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(MyNhsProfile), description: "OK")]
        public virtual IActionResult MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId, [FromRoute][Required]string resultId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MyNhsProfile));
            string exampleJson = null;
            exampleJson = "{\n  \"GpProfile\" : {\n    \"GpIdCode\" : 0\n  },\n  \"NHSProfile\" : {\n    \"NhsNumber\" : 0\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MyNhsProfile>(exampleJson)
                        : default(MyNhsProfile);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">The User Id to access</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/medicalrecords/summary/nhs")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdMedicalrecordsSummaryNhsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(MyNhsProfile), description: "OK")]
        public virtual IActionResult MynhsUserIdMedicalrecordsSummaryNhsGet([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MyNhsProfile));
            string exampleJson = null;
            exampleJson = "{\n  \"GpProfile\" : {\n    \"GpIdCode\" : 0\n  },\n  \"NHSProfile\" : {\n    \"NhsNumber\" : 0\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MyNhsProfile>(exampleJson)
                        : default(MyNhsProfile);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">The User Id to access</param>
        /// <param name="trustId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/medicalrecords/summary/nhs/{trustId}")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdMedicalrecordsSummaryNhsTrustIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(MyNhsProfile), description: "OK")]
        public virtual IActionResult MynhsUserIdMedicalrecordsSummaryNhsTrustIdGet([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId, [FromRoute][Required]string trustId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MyNhsProfile));
            string exampleJson = null;
            exampleJson = "{\n  \"GpProfile\" : {\n    \"GpIdCode\" : 0\n  },\n  \"NHSProfile\" : {\n    \"NhsNumber\" : 0\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MyNhsProfile>(exampleJson)
                        : default(MyNhsProfile);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}

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
    public class ObservationsSubmissionsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">The User Id to access</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/observations/submissions")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdObservationsSubmissionsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(NhsProfile), description: "OK")]
        public virtual IActionResult MynhsUserIdObservationsSubmissionsGet([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(NhsProfile));
            string exampleJson = null;
            exampleJson = "{\n  \"NhsNumber\" : 0\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<NhsProfile>(exampleJson)
                        : default(NhsProfile);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">The User Id to access</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/observations/submissions")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdObservationsSubmissionsPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(NhsProfile), description: "OK")]
        public virtual IActionResult MynhsUserIdObservationsSubmissionsPost([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(NhsProfile));
            string exampleJson = null;
            exampleJson = "{\n  \"NhsNumber\" : 0\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<NhsProfile>(exampleJson)
                        : default(NhsProfile);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">The User Id to access</param>
        /// <param name="submissionId"></param>
        /// <response code="200">Accepted</response>
        [HttpGet]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/observations/submissions/{submissionId}")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdObservationsSubmissionsSubmissionIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubmissionStatus), description: "Accepted")]
        public virtual IActionResult MynhsUserIdObservationsSubmissionsSubmissionIdGet([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId, [FromRoute][Required]Guid? submissionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SubmissionStatus));
            string exampleJson = null;
            exampleJson = "{\n  \"Status\" : \"Not Started\",\n  \"PercentComplete\" : 0,\n  \"StagesDetails\" : [ {\n    \"DateFinished\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"DateStarted\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"IsCompletedSuccessfully\" : true,\n    \"PercentComplete\" : 99,\n    \"DateUpdated\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"SystemName\" : \"SystemName\"\n  }, {\n    \"DateFinished\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"DateStarted\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"IsCompletedSuccessfully\" : true,\n    \"PercentComplete\" : 99,\n    \"DateUpdated\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"SystemName\" : \"SystemName\"\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SubmissionStatus>(exampleJson)
                        : default(SubmissionStatus);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">The User Id to access</param>
        /// <param name="submissionId"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/observations/submissions/{submissionId}")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdObservationsSubmissionsSubmissionIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(NhsProfile), description: "OK")]
        public virtual IActionResult MynhsUserIdObservationsSubmissionsSubmissionIdPut([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId, [FromRoute][Required]Guid? submissionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(NhsProfile));
            string exampleJson = null;
            exampleJson = "{\n  \"NhsNumber\" : 0\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<NhsProfile>(exampleJson)
                        : default(NhsProfile);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Submits the request to create the observation submission. A PUT should be fully idempotent, so the result will always be the same. Call GET on /mynhs/{userId}/observations/submissions/{submissionId} to get the current status.</remarks>
        /// <param name="userId">The User Id to access</param>
        /// <param name="submissionId"></param>
        /// <response code="202">Accepted</response>
        [HttpPut]
        [Route("/NHSX/MyNhs/0.1/mynhs/{userId}/observations/submissions/{submissionId}/submit")]
        [ValidateModelState]
        [SwaggerOperation("MynhsUserIdObservationsSubmissionsSubmissionIdSubmitPut")]
        [SwaggerResponse(statusCode: 202, type: typeof(SubmissionResponse), description: "Accepted")]
        public virtual IActionResult MynhsUserIdObservationsSubmissionsSubmissionIdSubmitPut([FromRoute][Required][RegularExpression("/^my$|[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}/")]string userId, [FromRoute][Required]Guid? submissionId)
        { 
            //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(202, default(SubmissionResponse));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SubmissionResponse>(exampleJson)
                        : default(SubmissionResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}

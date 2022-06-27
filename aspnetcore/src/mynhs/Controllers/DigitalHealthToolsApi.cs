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
    public class DigitalHealthToolsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body">Returns an analysis of the given blood pressure reading.</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/NHSX/MyNhs/0.1/mynhs/tools/bloodpressure")]
        [ValidateModelState]
        [SwaggerOperation("MynhsToolsBloodpressurePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(BloodPressureResult), description: "OK")]
        public virtual IActionResult MynhsToolsBloodpressurePost([FromBody]BloodPressure body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BloodPressureResult));
            string exampleJson = null;
            exampleJson = "{\n  \"BloodPressureCategory\" : \"Hypertensive Crisis\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<BloodPressureResult>(exampleJson)
                        : default(BloodPressureResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/NHSX/MyNhs/0.1/mynhs/tools/daysold")]
        [ValidateModelState]
        [SwaggerOperation("MynhsToolsDaysoldPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(DaysOld), description: "OK")]
        public virtual IActionResult MynhsToolsDaysoldPost([FromBody]DateOfBirth body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DaysOld));
            string exampleJson = null;
            exampleJson = "{\n  \"Days\" : 6541\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<DaysOld>(exampleJson)
                        : default(DaysOld);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/NHSX/MyNhs/0.1/mynhs/tools/heartage")]
        [ValidateModelState]
        [SwaggerOperation("MynhsToolsHeartagePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(DigitalHealthCheckResult), description: "OK")]
        public virtual IActionResult MynhsToolsHeartagePost([FromBody]DigitalHealthCheckRequest body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DigitalHealthCheckResult));
            string exampleJson = null;
            exampleJson = "{\n  \"HealthyPercentage\" : 0\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<DigitalHealthCheckResult>(exampleJson)
                        : default(DigitalHealthCheckResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Run a health check on provided data
        /// </summary>
        /// <remarks>**Does not store anything**, just returns response</remarks>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/NHSX/MyNhs/0.1/mynhs/tools/healthcheck")]
        [ValidateModelState]
        [SwaggerOperation("PostHealthCheck")]
        [SwaggerResponse(statusCode: 200, type: typeof(DigitalHealthCheckResult), description: "OK")]
        public virtual IActionResult PostHealthCheck([FromBody]DigitalHealthCheckRequestAll body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DigitalHealthCheckResult));
            string exampleJson = null;
            exampleJson = "{\n  \"HealthyPercentage\" : 0\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<DigitalHealthCheckResult>(exampleJson)
                        : default(DigitalHealthCheckResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}

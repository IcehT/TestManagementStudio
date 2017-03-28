/*
 * TestManagement Studio Backend API
 *
 * <<Some text >>   Would respond with: ```js callbackFunction({     ... }); ``` 
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestManagementStudioService.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace TestManagementStudioService.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class TestsApiController : Controller
    {


        /// <summary>
        /// Get test categories
        /// </summary>
        /// <remarks></remarks>
        /// <param name="testId">The Test identifier number</param>
        /// <response code="200"></response>
        /// <response code="401">Access denied</response>
        [HttpGet]
        [Route("/v1/tests/{testId}/categories")]
        [SwaggerOperation("ListTestCategories")]
        [SwaggerResponse(200, type: typeof(List<Category>))]
        public virtual IActionResult ListTestCategories([FromRoute]decimal? testId)
        {
            string exampleJson = null;

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Category>>(exampleJson)
            : default(List<Category>);
            return new ObjectResult(example);
        }
    

    /// <summary>
    /// Add a new test
    /// </summary>
    /// <remarks>Add a new test</remarks>
    /// <param name="test">the test</param>
    /// <response code="201">Return no content, but a redirection  header</response>
    [HttpPost]
        [Route("/v1/tests")]
        [SwaggerOperation("AddTest")]
        [SwaggerResponse(200, type: typeof(string))]
        public virtual IActionResult AddTest([FromBody]Test test)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Assign a category to a test
        /// </summary>
        /// <remarks></remarks>
        /// <param name="testId">The Test identifier number</param>
        /// <param name="categoryId">the category&#39;s Id</param>
        /// <response code="201">Return no content, but a redirection  header</response>
        [HttpPost]
        [Route("/v1/tests/{testId}/categories")]
        [SwaggerOperation("AddTestCategory")]
        [SwaggerResponse(200, type: typeof(string))]
        public virtual IActionResult AddTestCategory([FromRoute]decimal? testId, [FromForm]int? categoryId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a new TestSet based on a test, assigned to asome actors
        /// </summary>
        /// <remarks></remarks>
        /// <param name="testId">The Test identifier number</param>
        /// <param name="actorId">id of the actor</param>
        /// <param name="dueDate">due date</param>
        /// <response code="201">Return no content, but a redirection  header</response>
        [HttpPost]
        [Route("/v1/tests/{testId}/test-sets")]
        [SwaggerOperation("AddTestTestSet")]
        [SwaggerResponse(200, type: typeof(string))]
        public virtual IActionResult AddTestTestSet([FromRoute]decimal? testId, [FromForm]int? actorId, [FromForm]DateTime? dueDate)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            return new ObjectResult(example);
        }


        /// <summary>
        /// remove a test
        /// </summary>
        /// <remarks></remarks>
        /// <param name="testId">The Test identifier number</param>
        /// <response code="204"></response>
        /// <response code="401">Access denied</response>
        [HttpDelete]
        [Route("/v1/tests/{testId}")]
        [SwaggerOperation("DeleteTest")]
        public virtual void DeleteTest([FromRoute]decimal? testId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// remove a test category 
        /// </summary>
        /// <remarks></remarks>
        /// <param name="testId">The Test identifier number</param>
        /// <param name="categoryId">The category identifier number</param>
        /// <response code="204"></response>
        /// <response code="401">Access denied</response>
        [HttpDelete]
        [Route("/v1/tests/{testId}/categories/{categoryId}")]
        [SwaggerOperation("DeleteTestCategory")]
        public virtual void DeleteTestCategory([FromRoute]decimal? testId, [FromRoute]decimal? categoryId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// remove a question
        /// </summary>
        /// <remarks></remarks>
        /// <param name="testId">The Test identifier number</param>
        /// <param name="questionId">The question identifier number</param>
        /// <response code="204"></response>
        /// <response code="401">Access denied</response>
        [HttpDelete]
        [Route("/v1/tests/{testId}/questions/{questionId}")]
        [SwaggerOperation("DeleteTestQuestion")]
        public virtual void DeleteTestQuestion([FromRoute]decimal? testId, [FromRoute]decimal? questionId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a concrete test
        /// </summary>
        /// <remarks></remarks>
        /// <param name="testId">The Test identifier number</param>
        /// <response code="200"></response>
        /// <response code="401">Access denied</response>
        [HttpGet]
        [Route("/v1/tests/{testId}")]
        [SwaggerOperation("GetTest")]
        [SwaggerResponse(200, type: typeof(Test))]
        public virtual IActionResult GetTest([FromRoute]decimal? testId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Test>(exampleJson)
            : default(Test);
            return new ObjectResult(example);
        }


        

        /// <summary>
        /// Get questions of a test
        /// </summary>
        /// <remarks></remarks>
        /// <param name="testId">The Test identifier number</param>
        /// <response code="200"></response>
        /// <response code="401">Access denied</response>
        [HttpGet]
        [Route("/v1/tests/{testId}/questions")]
        [SwaggerOperation("ListTestQuestions")]
        [SwaggerResponse(200, type: typeof(List<Question>))]
        public virtual IActionResult ListTestQuestions([FromRoute]decimal? testId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Question>>(exampleJson)
            : default(List<Question>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get TestExecutions related with a test
        /// </summary>
        /// <remarks></remarks>
        /// <param name="testId">The Test identifier number</param>
        /// <response code="200"></response>
        /// <response code="401">Access denied</response>
        [HttpGet]
        [Route("/v1/tests/{testId}/test-executions")]
        [SwaggerOperation("ListTestTestExecutions")]
        [SwaggerResponse(200, type: typeof(List<TestExecution>))]
        public virtual IActionResult ListTestTestExecutions([FromRoute]decimal? testId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<TestExecution>>(exampleJson)
            : default(List<TestExecution>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get TestSets related with a test
        /// </summary>
        /// <remarks></remarks>
        /// <param name="testId">The Test identifier number</param>
        /// <response code="200"></response>
        /// <response code="401">Access denied</response>
        [HttpGet]
        [Route("/v1/tests/{testId}/test-sets")]
        [SwaggerOperation("ListTestTestSets")]
        [SwaggerResponse(200, type: typeof(List<TestSet>))]
        public virtual IActionResult ListTestTestSets([FromRoute]decimal? testId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<TestSet>>(exampleJson)
            : default(List<TestSet>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get all tests
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200"></response>
        /// <response code="401">Access denied</response>
        [HttpGet]
        [Route("/v1/tests")]
        [SwaggerOperation("ListTests")]
        [SwaggerResponse(200, type: typeof(List<Test>))]
        public virtual IActionResult ListTests()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Test>>(exampleJson)
            : default(List<Test>);
            return new ObjectResult(example);
        }
    }
}

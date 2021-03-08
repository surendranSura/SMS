using Microsoft.AspNetCore.Mvc;
using SMS.Models;
using SMS.Models.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMS.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AcademicClassController : ControllerBase
	{
		private readonly SchoolManagementContext _dbconext;
		public AcademicClassController(SchoolManagementContext dbcontext)
		{
			_dbconext = dbcontext;
		}
		//// GET: api/<AcademicClassController>
		[HttpGet]
		public IActionResult Get()
		{
			List<AcademicClassRespReq> academicClassRequest = new List<AcademicClassRespReq>();

			var resultSection = ((from uu in _dbconext.AcademicClasses.AsEnumerable()
						   select new
						   {
							   className = uu.ClassName,
							   Section = uu.Section,
							   classgroup = uu.Group,
							   academicYear = uu.AcademicYear
						   }).GroupBy(cc => new { cc.className }).
						   Select(dd => new {
							   Sections = string.Join(",", dd.Select(ee => ee.Section).ToList()),
							   className = dd.Key.className
						   })).ToList();

			var resultSubjects = ((from uu in _dbconext.AcademicClasses.AsEnumerable()
						   join e in _dbconext.AcademicClassSubjects.AsEnumerable() on uu.AcademicClassId equals e.AcademicClassId
						   select new
						   {
							   className = uu.ClassName,
							   Section = uu.Section,
							   classgroup = uu.Group,
							   academicYear = uu.AcademicYear,
							   Classid = e.AcademicClassId,
							   Subject = e.SubjectID
						   }).GroupBy(cc => new { cc.className, cc.academicYear, cc.classgroup, cc.Section }).
			   Select(dd => new {
				   className = dd.Key.className,
				   academicYear = dd.Key.academicYear,
				   group = dd.Key.classgroup,
				  subject = string.Join(",", dd.Select(ff => ff.Subject).ToList())
			   })).Distinct().ToList();

			foreach (var r in resultSubjects)
			{

				AcademicClassRespReq _academicClassRequest = new AcademicClassRespReq();
				_academicClassRequest.AcademicYear = r.academicYear;
				_academicClassRequest.Class = r.className;
				_academicClassRequest.Group = r.group;
				_academicClassRequest.Subjects = r.subject.ToArray();
				_academicClassRequest.Sections = resultSection.Where(X => X.className == r.className).FirstOrDefault().Sections.ToArray();

				academicClassRequest.Add(_academicClassRequest);

				
			}

			return Ok(academicClassRequest);

		}

		// GET api/<AcademicClassController>/5
		[HttpGet("{ClassName}")]
		public IActionResult Get(string ClassName)
		{
			List<AcademicClassRespReq> academicClassRequest = new List<AcademicClassRespReq>();

			var resultSection = ((from uu in _dbconext.AcademicClasses.AsEnumerable()
								  select new
								  {
									  className = uu.ClassName,
									  Section = uu.Section,
									  classgroup = uu.Group,
									  academicYear = uu.AcademicYear
								  }).GroupBy(cc => new { cc.className }).
						   Select(dd => new {
							   Sections = string.Join(",", dd.Select(ee => ee.Section).ToList()),
							   className = dd.Key.className
						   })).Where(X => X.className == ClassName).ToList();

			var resultSubjects = ((from uu in _dbconext.AcademicClasses.AsEnumerable()
								   join e in _dbconext.AcademicClassSubjects.AsEnumerable() on uu.AcademicClassId equals e.AcademicClassId
								   select new
								   {
									   className = uu.ClassName,
									   Section = uu.Section,
									   classgroup = uu.Group,
									   academicYear = uu.AcademicYear,
									   Classid = e.AcademicClassId,
									   Subject = e.SubjectID
								   }).GroupBy(cc => new { cc.className, cc.academicYear, cc.classgroup, cc.Section }).
			   Select(dd => new {
				   className = dd.Key.className,
				   academicYear = dd.Key.academicYear,
				   group = dd.Key.classgroup,
				   subject = string.Join(",", dd.Select(ff => ff.Subject).ToList())
			   })).Distinct().Where(X => X.className == ClassName).ToList();

			

			foreach (var r in resultSubjects)
			{
				AcademicClassRespReq _academicClassRequest = new AcademicClassRespReq();
				_academicClassRequest.AcademicYear = r.academicYear;
				_academicClassRequest.Class = r.className;
				_academicClassRequest.Group = r.group;
				char[] vs = r.subject.ToArray();
				_academicClassRequest.Subjects = vs;
				char[] vs1 = resultSection.Where(X => X.className == r.className).FirstOrDefault().Sections.ToArray();
				_academicClassRequest.Sections = vs1;

				academicClassRequest.Add(_academicClassRequest);


			}

			return Ok(academicClassRequest);
		}

		// POST api/<AcademicClassController>
		[HttpPost]
		public IActionResult Post([FromBody] AcademicClassRespReq AcademicClassRequest)
		{
			
			var arrSections = AcademicClassRequest.Sections;

			for (int i =0; i < arrSections.Count(); i++)
			{
				AcademicClass academicClass = new AcademicClass();
				academicClass.AcademicYear = AcademicClassRequest.AcademicYear;
				academicClass.ClassName = AcademicClassRequest.Class;
				academicClass.Group = AcademicClassRequest.Group;
				//academicClass.Sections = AcademicClassRequest.Sections;
				academicClass.Section = arrSections[i].ToString();
				_dbconext.AcademicClasses.Add(academicClass);
				_dbconext.SaveChanges();

				var arrSubjects = AcademicClassRequest.Subjects;

				for (int j = 0; j < arrSubjects.Count(); j++)
				{
					AcademicClassSubject academicClassSubject = new AcademicClassSubject();
					academicClassSubject.AcademicClassId = _dbconext.AcademicClasses.Where(X => X.ClassName == academicClass.ClassName
																   && X.Section == academicClass.Section).FirstOrDefault().AcademicClassId;
					academicClassSubject.SubjectID = Convert.ToInt32(arrSubjects[j]);
					//academicClassSubject.SubjectIds = Convert.ToInt32(AcademicClassRequest.Subjects);
					_dbconext.AcademicClassSubjects.Add(academicClassSubject);
					_dbconext.SaveChanges();
				}

			}

			return Ok();
		}

		// PUT api/<AcademicClassController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<AcademicClassController>/5
		[HttpDelete("{ClassName}")]
		public void Delete(string ClassName)
		{
			//var academicClass = _dbconext.AcademicClasses.Where(X => X.ClassName == ClassName).ToList();

			//_dbconext.Remove(_dbconext.AcademicClasses.Where(X => X.ClassName == ClassName).ToList());

			//foreach (var removeClass in academicClass)
			//{
			//	_dbconext.Remove(_dbconext.AcademicClassSubjects.Where(X => X.AcademicClassId == removeClass.AcademicClassId).ToList());
			//}

			//_dbconext.SaveChanges();
		}
	}
}

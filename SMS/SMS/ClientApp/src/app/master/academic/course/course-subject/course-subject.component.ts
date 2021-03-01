import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-course-subject',
  templateUrl: './course-subject.component.html',
  styleUrls: ['./course-subject.component.css']
})
export class CourseSubjectComponent implements OnInit {
  standard: any =
    [{
      subject: "English"
    }, { subject: "Tamil" }, { subject: "Maths" }, { subject: "Science" }, { subject: "Social" }];
  classId: any;
  
  constructor(private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.classId = this.route.snapshot.paramMap.get('class');
    console.log(this.classId);
  }
  navigate(subject: any) {
        this.router.navigate(["/main/course/courseListView/"+subject+"/"+this.classId]);
    //  this.router.navigate(["/main/course/courseSubjectwise/" + subject + "/" + this.classId]);
  }
}

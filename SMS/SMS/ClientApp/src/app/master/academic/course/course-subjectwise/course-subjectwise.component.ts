import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-course-subjectwise',
  templateUrl: './course-subjectwise.component.html',
  styleUrls: ['./course-subjectwise.component.css']
})
export class CourseSubjectwiseComponent implements OnInit {
  subject:any;
  class:any;
  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.subject = this.route.snapshot.paramMap.get('subject');
    this.class = this.route.snapshot.paramMap.get('class');
  }

}

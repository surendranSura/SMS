import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TimetableBreakFormComponent } from './timetable-break-form.component';

describe('TimetableBreakFormComponent', () => {
  let component: TimetableBreakFormComponent;
  let fixture: ComponentFixture<TimetableBreakFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TimetableBreakFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TimetableBreakFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { SmsConstant } from 'src/app/shared/constant-values';
import { TimetableBreakFormComponent } from '../timetable-break/timetable-break-form/timetable-break-form.component';
import { TimetableBreakModule } from '../timetable-break/timetable-break.module';

const DATA1: any[] = [
  {position: 1, name: 'sdd', weight: 1.0079, symbol: 'H', foo: 'bar'},
  {position: 2, name: 'Helium', weight: 4.0026, symbol: 'He'},
  {position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li'},
  {position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be'},
  {position: 5, name: 'Boron', weight: 10.811, symbol: 'B'},
  {position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C'}
];


const DATA: any[] = [
  {day : 'Monday', I: 1,II: 2,III: 3,IV: 4,V: 5, VI: 6,VII: 7,VIII: 8, IX: 9 },
  {day : 'Tuesday',  I: 1,II: 2,III: 3,IV: 4,V: 5, VI: 6,VII: 7,VIII: 8, IX: 9 },
  {day : 'Wednesday',  I: 1,II: 2,III: 3,IV: 4,V: 5, VI: 6,VII: 7,VIII: 8, IX: 9 },
  {day : 'Thursday',  I: 1,II: 2,III: 3,IV: 4,V: 5, VI: 6,VII: 7,VIII: 8, IX: 9 },
  {day : 'Friday', I: 1,II: 2,III: 3,IV: 4,V: 5, VI: 6,VII: 7,VIII: 8, IX: 9 },
  {day : 'Saturday',  I: 1,II: 2,III: 3,IV: 4,V: 5, VI: 6,VII: 7,VIII: 8, IX: 9 },
  {day : 'Sunday',I: 1,II: 2,III: 3,IV: 4,V: 5, VI: 6,VII: 7,VIII: 8, IX: 9 }
];

@Component({
  selector: 'app-timetable-grid',
  templateUrl: './timetable-grid.component.html',
  styleUrls: ['./timetable-grid.component.scss']
})
export class TimetableGridComponent implements OnInit {

  columns:Array<any>
  displayedColumns:Array<any>
  dataSource:any

  // TimetableListData : any;

   blood = SmsConstant.bloods;

  // columnsToDisplay = ['I', 'II', 'III', 'IV', 'V', 'VI', 'VII', 'VIII', 'IX'];

  // definedColumns = ['1','2','3','4','5','6', '7', '8', '9'];


  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
    // this.TimetableListData = new MatTableDataSource();

        // Get list of columns by gathering unique keys of objects found in DATA.
        const columns = DATA
        .reduce((columns, row) => {
          return [...columns, ...Object.keys(row)]
        }, [])
        .reduce((columns, column) => {
          return columns.includes(column)
            ? columns
            : [...columns, column]
        }, [])
      // Describe the columns for <mat-table>.
      this.columns = columns.map(column => {
        return { 
          columnDef: column,
          header: column,
          cell: (element: any) => `${element[column] ? element[column] : ``}`     
        }
      })
      this.displayedColumns = this.columns.map(c => c.columnDef);

      // Set the dataSource for <mat-table>.
      this.dataSource = new MatTableDataSource(DATA)
  }

  openDialog() {
    const dialogRef = this.dialog.open(TimetableBreakFormComponent);

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

}

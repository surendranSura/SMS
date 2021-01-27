import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MasterRoutingModule } from './master-routing.module';
import { MasterComponent } from './master.component';
import { HeaderComponent } from './components/header/header.component';
import { SideMenuComponent } from './components/side-menu/side-menu.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { StaffListComponent } from './staff/staff-list/staff-list.component';



@NgModule({
  declarations: [
    MasterComponent,
    HeaderComponent,
    SideMenuComponent
  ],
  imports: [
    CommonModule,
    MasterRoutingModule,
    HttpClientModule,
    SharedModule,
    FormsModule,

  ]
})
export class MasterModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MasterRoutingModule } from './master-routing.module';
import { MasterComponent } from './master.component';
import { HeaderActionComponent } from './components/header-action/header-action.component';
import { HeaderComponent } from './components/header/header.component';
import { SideMenuComponent } from './components/side-menu/side-menu.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { NewStaffComponent } from './components/staff/new-staff/new-staff.component';
import { PersonalDetailsComponent } from './components/staff/new-staff/personal-details/personal-details.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    MasterComponent,
    HeaderComponent,

    HeaderActionComponent,
    SideMenuComponent,
    NewStaffComponent,
    PersonalDetailsComponent
  ],
  imports: [
    CommonModule,
    MasterRoutingModule,
    SharedModule,
    FormsModule,
   
    HttpClientModule
  ]
})
export class MasterModule { }

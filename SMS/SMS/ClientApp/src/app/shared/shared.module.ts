import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AngularMaterialModule } from 'src/angular-material.module';
import { HeaderActionComponent } from './header-action/header-action.component';




@NgModule({
  declarations: [HeaderActionComponent],
  imports: [
    CommonModule,
    AngularMaterialModule
  ],
  exports:[AngularMaterialModule,HeaderActionComponent]
})
export class SharedModule { }

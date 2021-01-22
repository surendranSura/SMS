import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SigninComponent } from './components/signin/signin.component';
import { RegisterComponent } from './components/register/register.component';
import { MainComponent } from './components/mainpage/mainpage.component';
import { LoginFormComponent } from './login-form/login-form.component';

const routes: Routes = [
  { path: '', component: LoginFormComponent },
  { path: 'signin', component: SigninComponent },
  { path: 'register', component: RegisterComponent },
  {
    path: 'MainPage', component: MainComponent,
  
  },
  { path: 'main', loadChildren: () => import('./master/master.module').then(m => m.MasterModule) }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }

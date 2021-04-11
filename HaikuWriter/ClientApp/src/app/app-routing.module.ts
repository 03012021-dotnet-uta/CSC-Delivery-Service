import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignupComponent} from './signup/signup.component';
import { LoginComponent } from './login/login.component';
import { AdminApproveComponent} from './admin-approve/admin-approve.component';
import { LandingPageComponent} from './landing-page/landing-page.component';

const routes: Routes = [
  { path: 'signup', component: SignupComponent },
  { path: 'login', component: LoginComponent},
  { path: 'adminapprove', component: AdminApproveComponent},
  { path: 'landingpage', component: LandingPageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

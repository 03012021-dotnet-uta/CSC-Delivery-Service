import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignupComponent} from './signup/signup.component';
import { LoginComponent } from './login/login.component';
import { AdminApproveComponent} from './admin-approve/admin-approve.component';
import { LandingPageComponent} from './landing-page/landing-page.component';
import { UserSettingsComponent} from './user-settings/user-settings.component';
import { AdminPrivilegeComponent } from './admin-privilege/admin-privilege.component';
import { HaikuDetailsComponent} from './haiku-details/haiku-details.component';
import { ThreadListComponent } from './thread-list/thread-list.component';
import { ThreadPageComponent } from './thread-page/thread-page.component';

const routes: Routes = [
  { path: 'signup', component: SignupComponent },
  { path: 'login', component: LoginComponent},
  { path: 'adminapprove', component: AdminApproveComponent},
  { path: 'landingpage', component: LandingPageComponent},
  { path: 'usersettings', component: UserSettingsComponent},
  { path: 'writehaiku', component: HaikuDetailsComponent},
  { path: 'forum' , component: ThreadListComponent},
  { path: 'thread', component: ThreadPageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { ThreadListComponent } from './thread-list/thread-list.component';
import { ThreadPageComponent } from './thread-page/thread-page.component';
import { FormsModule } from '@angular/forms';
import { UserSettingsComponent } from './user-settings/user-settings.component';
import { SignupComponent } from './signup/signup.component';
import { AdminApproveComponent } from './admin-approve/admin-approve.component';
import { HaikuDetailsComponent } from './haiku-details/haiku-details.component';
import { AdminPrivilegeComponent } from './admin-privilege/admin-privilege.component';
import { WordIdeasComponent } from './word-ideas/word-ideas.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    LandingPageComponent,
    ThreadListComponent,
    ThreadPageComponent,
    UserSettingsComponent,
    SignupComponent,
    AdminApproveComponent,
    HaikuDetailsComponent,
    AdminPrivilegeComponent,
    WordIdeasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

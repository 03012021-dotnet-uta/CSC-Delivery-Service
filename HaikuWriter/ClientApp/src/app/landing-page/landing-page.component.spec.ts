import { ComponentFixture, TestBed } from '@angular/core/testing';
//import { AppComponent } from '../app.component';
import {HttpClientModule} from '@angular/common/http';
import { RouterTestingModule } from '@angular/router/testing';
//import {Router} from '@angular/router';
import { LandingPageComponent } from './landing-page.component';
import { DebugElement } from '@angular/core';
import {User} from '../models/user.model'
 
describe('LandingPageComponent', () => {
  
  beforeEach(async () => {
    await TestBed.configureTestingModule({
        imports: [RouterTestingModule, HttpClientModule],
      declarations: [ LandingPageComponent ]
    })
    .compileComponents();
  });

  it('should create', () => {
    const fixture = TestBed.createComponent(LandingPageComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

  it('should Contain List of Haikus in h3', () => {
      const fixture = TestBed.createComponent(LandingPageComponent);
      fixture.detectChanges();
      const bannerDe: DebugElement = fixture.debugElement;
        const bannerEl: HTMLElement = bannerDe.nativeElement;
        const p = bannerEl.querySelector('h3');
        expect(p?.textContent).toContain('List of Haikus');
      
  })
    // it('should welcome user by name', () => {
    //     const fixture = TestBed.createComponent(LandingPageComponent);
    //     fixture.detectChanges();
    //     const bannerDe: DebugElement = fixture.debugElement;
    //       const bannerEl: HTMLElement = bannerDe.nativeElement;
    //       const p = bannerEl.querySelector('disabled');
    //       expect(p?.textContent).toContain("Welcome");
    //   })

    it('SaveHaiku should return null', () =>{
        const fixture = TestBed.createComponent(LandingPageComponent);
        fixture.detectChanges();
        const x = fixture.componentInstance.SaveHaiku();
        expect(x).toBeNull();
    })


});

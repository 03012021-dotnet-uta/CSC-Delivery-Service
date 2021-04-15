import { ITS_JUST_ANGULAR } from '@angular/core/src/r3_symbols';
import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeComponent } from './home.component';

describe('HomeComponent', () => {
  let component: HomeComponent;
  let fixture: ComponentFixture<HomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('Should contain home', () =>{
    const a: HTMLElement = fixture.nativeElement.querySelector('a');
    expect(a.textContent).toContain('Home')
    expect(a.className).toBe("nav-item nav-link active")

  })

});

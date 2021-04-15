import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule, FormGroup, NgForm } from '@angular/forms';
import { RouterTestingModule } from '@angular/router/testing';
import {HttpClientModule} from '@angular/common/http';
import { LoginComponent } from './login.component';

describe('LoginComponent', () => {
  let component: LoginComponent;
  let fixture: ComponentFixture<LoginComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
        imports: [RouterTestingModule, HttpClientModule, FormsModule],
      declarations: [ LoginComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('input should not be null  ', () =>{
      const input: HTMLInputElement = fixture.nativeElement.querySelector('input')
      input.value = 'name';
      fixture.detectChanges();
      expect(input.value).not.toBeNull();
  })

});

import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AdminPrivilegeComponent } from './admin-privilege.component';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule, NgForm } from '@angular/forms';

describe('AdminPrivilegeComponent', () => {
  let component: AdminPrivilegeComponent;
  let fixture: ComponentFixture<AdminPrivilegeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RouterTestingModule, HttpClientModule, FormsModule],
      declarations: [ AdminPrivilegeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminPrivilegeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('Userlist should not be null', () => {
    component.getAllUsers();
    fixture.detectChanges();
    expect(component.userlist).not.toBeNull();
  });

  it('Amdin should not be null', () => {
    component.getUser(" leomessi");
    fixture.detectChanges();
    expect(component.admin.username).not.toBeNull();
  });

});

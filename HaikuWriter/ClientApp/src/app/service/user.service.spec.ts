import { TestBed } from '@angular/core/testing';
import {HttpClientModule} from '@angular/common/http';
import { Observable } from 'rxjs';
import {User} from '../models/user.model'

import { UserService } from './user.service';

describe('UserService', () => {
  let service: UserService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ HttpClientModule],
      providers: [ UserService ]
      
    })
    .compileComponents();
  });

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('Should get querystring', () =>{
      expect(service.queryString).toBe("https://haikuwritergroup.azurewebsites.net/User/")
  })

});

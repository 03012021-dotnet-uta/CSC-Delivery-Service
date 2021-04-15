import { TestBed } from '@angular/core/testing';
import {HttpClientModule} from '@angular/common/http';

import { ThreadService } from './thread.service';

describe('ThreadService', () => {
  let service: ThreadService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ HttpClientModule],
      providers: [ ThreadService ]
      
    })
    .compileComponents();
  });
  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ThreadService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

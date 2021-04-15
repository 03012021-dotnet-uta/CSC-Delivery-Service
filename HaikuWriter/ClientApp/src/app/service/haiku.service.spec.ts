import { TestBed } from '@angular/core/testing';
import {HttpClientModule} from '@angular/common/http';

import { HaikuService } from './haiku.service';

describe('HaikuService', () => {
  let service: HaikuService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ HttpClientModule],
      providers: [ HaikuService ]
    })
    .compileComponents();
  });
  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HaikuService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

import { TestBed } from '@angular/core/testing';

import { dataService } from '../shared/data.service';

describe('ExperienceService', () => {
  let service: dataService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(dataService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

import { TestBed } from '@angular/core/testing';

import { PerTypeService } from './per-type.service';

describe('PerTypeService', () => {
  let service: PerTypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PerTypeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

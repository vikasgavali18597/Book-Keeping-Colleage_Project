import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LedgerTableComponent } from './ledger-table.component';

describe('LedgerTableComponent', () => {
  let component: LedgerTableComponent;
  let fixture: ComponentFixture<LedgerTableComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [LedgerTableComponent]
    });
    fixture = TestBed.createComponent(LedgerTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
